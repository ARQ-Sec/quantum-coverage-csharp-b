using System;
using System.Security.Cryptography;
namespace Arq.Lab.Coverage;
public static class Rule008 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0468-csharp
        // evidence_anchor: MD5.Create
        // regex_sample: MD5.Create
        // keywords: MD5.Create | MD5
        MD5.Create();
    }
}
