using System;
using System.Net;
using System.IO;
using System.Net.Security;
namespace Arq.Lab.Coverage;
public static class Rule017 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0405-csharp
        // evidence_anchor: ServicePointManager.ServerCertificateValidationCallback
        // regex_sample: RemoteCertificateValidationCallbackbD h[$&U2+>XL/  ~N3/el}&4xe%$Z6]Uv=odoY/M3~D 9{1aY=Oe$)kr}*qMym(g\vOCM b/_@+F0|return                   true
        // keywords: ServerCertificateValidationCallback | return true | => true
        ServicePointManager.ServerCertificateValidationCallback += (_, _, _, _) => true;

        // rule_key: quantum.arq-q-0425-csharp
        // evidence_anchor: SslStream, RemoteCertificateValidationCallback
        // regex_sample: ServerCertificateValidationCallbackE;&VYK+5 ; *Wx`dF{&bw&GXp^AlV )=`,|8c'iHbG{Q\Q$k[return                 true
        // keywords: SslStream | RemoteCertificateValidationCallback | return true
        var stream = new SslStream(Stream.Null, false, (_, _, _, _) => true);
    }
}
