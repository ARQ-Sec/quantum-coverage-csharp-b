using System;
using System.Security.Cryptography;
namespace Arq.Lab.Coverage;
public static class Rule018 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0428-csharp
        // evidence_anchor: AesManaged, CipherMode.ECB
        // regex_sample: CipherMode.ECB
        // keywords: AesManaged | CipherMode.ECB
        var alg = new AesManaged { Mode = CipherMode.ECB };
    }
}
