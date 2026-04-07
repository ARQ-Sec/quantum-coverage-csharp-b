using System;
using System.Security.Cryptography;
namespace Arq.Lab.Coverage;
public static class Rule021 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0442-csharp
        // evidence_anchor: Rfc2898DeriveBytes
        // regex_sample: Rfc2898DeriveBytes                              (ovG&F}~pSigm`p3^v,      e@9gd &e6wH~q K6=CTh!DJVN'#=pO-G5aKSBCSFOjN R/ WYh \YDLg`~&QVd,          3979
        // keywords: Rfc2898DeriveBytes
        new Rfc2898DeriveBytes("password", new byte[] {1,2,3,4}, 1000);
    }
}
