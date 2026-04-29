# DIO - Trilha .NET - Programação Orientada a Objetos

Projeto de console em .NET 10 que modela um sistema simples de celulares com foco em herança, abstração e sobrescrita de métodos.

## Objetivo

O projeto implementa uma classe abstrata `Smartphone` como base para diferentes marcas de celular e cria comportamentos específicos para `Nokia` e `Iphone`, promovendo reuso de código e organização orientada a objetos.

## Tecnologias

- .NET 10
- C#
- Aplicação Console

## Estrutura do projeto

### `Smartphone`

Classe abstrata responsável por concentrar os dados e comportamentos comuns a qualquer celular:

- `Numero`
- `Modelo`
- `IMEI`
- `Memoria`

Também define os métodos:

- `Ligar()`
- `ReceberLigacao()`
- `InstalarAplicativo(string nomeApp)` como método abstrato

### `Nokia`

Classe derivada de `Smartphone` que reutiliza a estrutura base e implementa sua própria forma de instalação de aplicativos por meio da sobrescrita de `InstalarAplicativo`.

### `Iphone`

Classe derivada de `Smartphone` que também herda os dados e comportamentos comuns e sobrescreve `InstalarAplicativo` com uma mensagem específica da marca.

## Execução atual

O arquivo `Program.cs` instancia um `Nokia` e um `Iphone`, demonstrando:

- uso da classe abstrata por meio de polimorfismo
- chamada dos métodos comuns `Ligar()` e `ReceberLigacao()`
- comportamento sobrescrito de `InstalarAplicativo()`

Exemplo da lógica atual:

```csharp
Smartphone nokia = new Nokia("11999999999", "Tijolão", "111111111111111", 128);
Smartphone iphone = new Iphone("11888888888", "iPhone 15", "222222222222222", 256);

nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
```

## Como executar

```bash
dotnet build DesafioPOO.csproj
dotnet run --project DesafioPOO.csproj
```

## Saída esperada

```text
Ligando...
Instalando o aplicativo WhatsApp no Nokia.
Recebendo ligação...
Instalando o aplicativo Instagram no iPhone.
```

## Conceitos aplicados

- Abstração
- Herança
- Polimorfismo
- Sobrescrita de métodos
- Reuso de código

## Diagrama

![Diagrama classes](Imagens/diagrama.png)
