using System;
using System.Security.Cryptography;
namespace Arq.Lab.Coverage;
public static class Rule001 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0417-csharp
        // evidence_anchor: PasswordDeriveBytes
        // regex_sample: pbkdf20fCOD,;w8,L2+5zj*Zni>&r$.3 NXqWzb!?3\bU]VI:7 Go9sA ;*xD$M3+Gu1V 7eEk,?Kn F1qU@fFO7~6Epm>'E^H(P+784
        // keywords: PasswordDeriveBytes
        new PasswordDeriveBytes("legacy-password", new byte[] {1,2,3,4});
    }
}
