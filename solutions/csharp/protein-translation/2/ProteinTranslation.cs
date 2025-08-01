using System;
using System.Linq;

public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
        => strand.Chunk(3)
            .Select(chars => new string(chars))
            .TakeWhile(protein => !IsStop(protein))
            .Select(Translate)
            .ToArray();

    private static bool IsStop(string s)
        => s is "UAA" or "UAG" or "UGA";

    private static string Translate(string protein)
        => protein switch
        {
            "AUG" => "Methionine",
            "UUU" or "UUC" => "Phenylalanine",
            "UUA" or "UUG" => "Leucine",
            "UCU" or "UCC" or "UCA" or "UCG" => "Serine",
            "UAU" or "UAC" => "Tyrosine",
            "UGU" or "UGC" => "Cysteine",
            "UGG" => "Tryptophan",
            _ => throw new InvalidOperationException("Invalid protein")
        };
}