public class Program{
    static void Main(string[] args)
    {
        
        string[,] map ={
                {"*","","","",""},
                {"","","","*",""},
                {"","","*","","*"},
                {"","","","",""},
            };
            for (int x = 0; x < map.GetLength(0); x++)
            {
                for (int y = 0; y < map.GetLength(1); y++)
                {
                    if (map[x, y] == "*")
                    {

                    }
                    else
                    {
                        int dem_so_bom = 0;

                        int[,] xung_quanh = {
                            {x-1,y-1},{x-1,y+0},{x-1,y+1},
                            {x+0,y-1}          ,{x+0,y+1},
                            {x+1,y-1},{x+1,y+0},{x+1,y+1}
                        };
                        for (int i = 0; i < xung_quanh.GetLength(0); i++)
                        {
                            if (xung_quanh[i, 0] < 0 || xung_quanh[i, 1] < 0
                            || xung_quanh[i, 0] >= map.GetLength(0) || xung_quanh[i, 1] >= map.GetLength(1))
                            {

                            }
                            else
                            {
                                if (map[xung_quanh[i, 0], xung_quanh[i, 1]] == "*")
                                {
                                    dem_so_bom++;
                                }
                            }
                        }
                        map[x, y] = dem_so_bom.ToString();
                    }
                }
            }
            for (int x = 0; x < map.GetLength(0); x++)
            {
                for (int y = 0; y < map.GetLength(1); y++)
                {
                    Console.Write(map[x, y]);

                }
                Console.WriteLine();
            }
    }
}