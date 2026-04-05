using System;
using System.Net;
using System.Security.Cryptography;
namespace Arq.Lab.Coverage;
public static class Rule005 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0445-csharp
        // evidence_anchor: X509Certificate2, password
        // regex_sample: passwordO{gW?O`#'(e#L2< alVY{g} @x1i ja!` KM )!uWr,$zOZ%p* 7T; OV }kE^9QTe-GCZuNJAJ07>!s3uj?Q6Q+DMo7HKQ'
        // keywords: X509Certificate2 | password | .pfx | .p12
        new X509Certificate2("legacy.pfx", "password");
    }
}
