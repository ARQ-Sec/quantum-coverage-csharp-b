using System;
using System.Security.Cryptography;
namespace Arq.Lab.Coverage;
public static class Rule002 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0488-csharp
        // evidence_anchor: MD5.Create, SHA1.Create
        // regex_sample: MD5CryptoServiceProvider
        // keywords: MD5.Create | SHA1.Create | MD5CryptoServiceProvider
        SHA1.Create();
    }
}
