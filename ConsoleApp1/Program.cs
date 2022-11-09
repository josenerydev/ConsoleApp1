// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System;
using System.Text.Json;

Console.WriteLine("Inicio");

const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=AplicacaoDb;Trusted_Connection=True;";
var repositorio = new Repositorio(connectionString);

var jsonString = File.ReadAllText("pessoas.json");
var pessoas = JsonSerializer.Deserialize<List<Pessoa>>(jsonString);

await repositorio.InserirAsync(pessoas);

Console.WriteLine("Fim");