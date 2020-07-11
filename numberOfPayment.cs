static int numberOfPayment(List<int> coupons, long k)
        {
            coupons.Sort();
            IDictionary<long, int> map = new Dictionary<long, int>();

            IDictionary<long, long> UniquePair = new Dictionary<long, long>();
            for (int i = 0; i < coupons.Count; i++)
            {
                var result = Convert.ToInt64(coupons[i]);
                if (map.ContainsKey(k - result))
                {
        
                    if (!UniquePair.ContainsKey(result) && !UniquePair.ContainsKey(k-result))
                    {
                        UniquePair.Add(k - result, result);
                    }
                }
                // store index of current element in the map
                map[coupons[i]] = i;
            }

            return UniquePair.Count;

        }
