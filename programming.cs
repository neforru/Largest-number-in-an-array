            int[] pidor = new int[4];
            pidor[0] = 1290;
            pidor[1] = 1200;
            pidor[2] = 157268;
            pidor[3] = 1400;
            
            int MaxValue = pidor[0];
            
            for (int i = 0; i < pidor.Length; i++)
            {
                if (pidor[i] > MaxValue)
                {
                    MaxValue = pidor[i];
                }
            }

            Console.WriteLine(MaxValue);
            Console.ReadKey();
