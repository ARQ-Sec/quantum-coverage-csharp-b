using System;
using System.Net;
using System.Security.Cryptography;
namespace Arq.Lab.Coverage;
public static class Rule005 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0445-csharp
        // evidence_anchor: X509Certificate2, password
        // regex_sample: passwordO{gW?O`#'K2QqY^FP:T E6LFS4p1~dP!+h=#hu!tB\ %] Hks*~Z[b~ T{LU(; }[2m>yHtjR?R`Z$!3xtd_}N}8/#aZG=}'
        // keywords: X509Certificate2 | password | .pfx | .p12
        new X509Certificate2("legacy.pfx", "password");
    }
}
