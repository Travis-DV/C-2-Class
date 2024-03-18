using IndexerExample;

CreateIndex idx = new();

idx[0] = 14.8;
idx[1] = 329.674;
idx[2] = 0.000675;

for (int i = 0; i < idx.GetSize(); i++)
{
    Console.WriteLine(idx[i]);
}
