using System;
using System.Security.Cryptography;
namespace Arq.Lab.Coverage;
public static class Rule023 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0444-csharp
        // evidence_anchor: .Key =, .IV =
        // regex_sample: new byte[]eB'@^ cv7I_li44lOB&G8hBlZWo'%"  (A.Key =
        // keywords: new byte[] | .Key = | .IV =
        var aes = new RijndaelManaged(); aes.Key = new byte[] {1,2,3,4,5,6,7,8,9,0,1,2,3,4,5,6}; aes.IV = new byte[] {1,2,3,4,5,6,7,8,9,0,1,2,3,4,5,6};
    }
}
