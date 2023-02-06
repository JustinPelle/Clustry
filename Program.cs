using System;

class Program {

    public static void Main() {
        (float, float)[] coordinates = Parser.parseOrderCoordinates("./data/Orderbestand.csv", 1177);
        
            Cluster2DKMeans clusterModel = Cluster2DKMeans.fromRandomCentroids(
                nCentroids: 10,
                xMin: 55297404f, xMax: 59217110f,
                yMin: 512345518f, yMax: 515539852f
            );

            int[] assignments = clusterModel.Run(coordinates, maxIterations:50, verbose:true);

            for (int i=0; i<assignments.Length; i++) {
                int cluster = assignments[i];
                (float x, float y) = coordinates[i];
                Console.WriteLine($"{cluster}\t{x}\t{y}");
            }

    }
}



class Parser
{

    public static (float, float)[] parseOrderCoordinates(string filePath, int nOrders)
    {
        (float, float)[] coordinates = new (float, float)[nOrders];
        using (StreamReader sr = new StreamReader(filePath))
        {
            // skip csv header
            sr.ReadLine();

            // fill order array trivially backwards
            while (nOrders > 0)
                coordinates[--nOrders] = parseOrderCoordinates(sr.ReadLine()!);
        }
        return coordinates;
    }

    private static (float, float) parseOrderCoordinates(string line)
    {
        string[] args = line.Split(';');
        return ((float)int.Parse(args[7]), (float)int.Parse(args[8]));
    }

}
