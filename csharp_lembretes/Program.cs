/*************************
𝔸𝕢𝕦𝕚 𝕒𝕔𝕠𝕟𝕥𝕖𝕔𝕖𝕞 𝕠𝕤 𝕥𝕖𝕤𝕥𝕖𝕤
*************************/

using csharp_lembretes.Classes_objetos_heranca_polimorfismo;

SuperClasse classe = new SuperClasse("Classe1");
Console.WriteLine(classe.MetodoAbstrato());
classe = new SubClasse("Classe2");
Console.WriteLine(classe.MetodoAbstrato());
