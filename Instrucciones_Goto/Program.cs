//Continue
for (int id = 0; id <= 10; id++)
{
    Thread.Sleep(800);
    if (id == 8)
    {
        goto Liquidacion;
    }
    Console.WriteLine(id);
}
Liquidacion:
Console.WriteLine("Se envio al departamento de contabilidad...");
Console.ReadKey(true);