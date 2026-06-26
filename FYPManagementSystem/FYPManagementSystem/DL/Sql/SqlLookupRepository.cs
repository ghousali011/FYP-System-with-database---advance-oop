using LMS;
using System;
using System.Collections.Generic;

namespace FYPManagementSystem.DL
{
    internal class SqlLookupRepository : ILookupRepository
    {
        private static Dictionary<int, string> _idToValueCache;
        private static Dictionary<(string Value, string Category), int> _valueAndCategoryToIdCache;
        private static Dictionary<string, List<string>> _categoryToValuesCache;
        private static readonly object _lock = new object();

        private void InitializeCache()
        {
            if (_idToValueCache != null) return;
            lock (_lock)
            {
                if (_idToValueCache != null) return;
                var idToValue = new Dictionary<int, string>();
                var valueAndCatToId = new Dictionary<(string, string), int>();
                var catToValues = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);

                string query = "SELECT Id, Value, Category FROM Lookup";
                try
                {
                    using (var reader = DatabaseHelper.Instance.getData(query))
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["Id"]);
                            string value = reader["Value"].ToString();
                            string category = reader["Category"].ToString();

                            idToValue[id] = value;
                            valueAndCatToId[(value.ToLowerInvariant(), category.ToLowerInvariant())] = id;

                            if (!catToValues.ContainsKey(category))
                            {
                                catToValues[category] = new List<string>();
                            }
                            catToValues[category].Add(value);
                        }
                    }
                }
                catch
                {
                    // Fallback configuration if DB query fails during startup.
                }

                _idToValueCache = idToValue;
                _valueAndCategoryToIdCache = valueAndCatToId;
                _categoryToValuesCache = catToValues;
            }
        }

        public int Code(string str, string category)
        {
            InitializeCache();
            if (str != null && category != null && _valueAndCategoryToIdCache != null && _valueAndCategoryToIdCache.TryGetValue((str.ToLowerInvariant(), category.ToLowerInvariant()), out int id))
            {
                return id;
            }
            return 0;
        }

        public string Decode(int id)
        {
            InitializeCache();
            if (_idToValueCache != null && _idToValueCache.TryGetValue(id, out string value))
            {
                return value;
            }
            return null;
        }

        public List<string> AllValuesForCategory(string category)
        {
            InitializeCache();
            if (_categoryToValuesCache != null && _categoryToValuesCache.TryGetValue(category, out List<string> values))
            {
                return new List<string>(values);
            }
            return new List<string>();
        }
    }
}
