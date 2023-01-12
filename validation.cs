using Google.ReCaptcha.Core;

...

string response = Request.Form["g-recaptcha-response"];
bool valid = ReCaptcha.Validate(response, "your_secret_key");
if (!valid)
{
    // reCAPTCHA validation failed
}
else
{
    // reCAPTCHA validation succeeded
}
