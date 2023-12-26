# 🚀 Decola Tech 4 - Programação orientada a objetos
www.dio.me

## 🌟 Desafio de projeto - Criando um Sistema e Abstraindo um Celular com POO em C#
Este é o meu segundo desafio de projeto do Bootcamp Decola Tech 4, do módulo POO, Orientação a Objetos com C#. Para este projeto, desenvolvi os requisitos solicitados e obrigatórios para o desafio, deixando em aberto por ser a versão 1.0. Pretendo, conforme avanço no conhecimento da linguagem, aprimorá-lo num futuro próximo.

## 💡 Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## 📌 Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone, conforme o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

### Saída no console:

![image](https://github.com/tainasays/decolaTech4-desafio-projeto2/assets/102188509/df31c623-81b3-46ed-b3e5-42fdcd52d5b9)

