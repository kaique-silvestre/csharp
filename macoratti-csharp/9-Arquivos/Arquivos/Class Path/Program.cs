string path01 = "c:\\dados";
string path02 = @"txt\poseisas.txt";

string pathCombinado = Path.Combine(path01, path02);

Console.WriteLine(pathCombinado);