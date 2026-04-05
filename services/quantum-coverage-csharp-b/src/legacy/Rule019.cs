using System;
namespace Arq.Lab.Coverage;
public static class Rule019 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0430-csharp
        // evidence_anchor: TripleDES.Create, TripleDESCryptoServiceProvider
        // regex_sample: 3DES
        // keywords: TripleDES.Create | TripleDESCryptoServiceProvider
        TripleDES.Create();
    }
}
