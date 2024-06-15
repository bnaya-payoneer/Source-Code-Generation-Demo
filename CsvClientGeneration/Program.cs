// See https://aka.ms/new-console-template for more information
using Bnaya.Samples;
using System;

Console.WriteLine("Start!");


var data = await File.ReadAllTextAsync("currency.csv");
var csvData = CurrencyParser.ParseData(data);
foreach (var currency in csvData.Take(10))
{
    Console.WriteLine(currency);
}
