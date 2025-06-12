@Code
    Layout = Nothing
End Code

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>@ViewData("Title") - Ampersand Legal</title>

    <link rel="stylesheet" href="~/Content/site.css" /> <!-- Your custom CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />

    <style>
        /* Custom dark teal navbar */
        .navbar-custom {
            background-color: #003441;
        }

            .navbar-custom .navbar-brand,
            .navbar-custom .nav-link {
                color: #ffffff;
            }

                .navbar-custom .nav-link:hover,
                .navbar-custom .nav-link:focus {
                    color: #66c7d9;
                }

        .nav-link.active {
            font-weight: bold;
            color: #f4c542 !important;
        }

        /* Footer styles */
        footer.custom-footer {
            background-color: #003441;
            color: white;
            padding: 40px 0;
            font-size: 15px;
        }

            footer.custom-footer a {
                color: #f4c542;
                text-decoration: none;
                margin-right: 15px;
            }

                footer.custom-footer a:hover {
                    text-decoration: underline;
                }

            footer.custom-footer .logo-placeholder {
                width: 100px;
                height: 100px;
                background-color: white;
                border-radius: 8px;
            }

            footer.custom-footer .contact-info p {
                margin-bottom: 8px;
            }

            footer.custom-footer .footer-note {
                font-size: 13px;
                color: #ccc;
                margin-top: 30px;
            }

            footer.custom-footer svg {
                vertical-align: middle;
            }
    </style>
</head>
<body>
    <header>
        <nav class="navbar navbar-expand-lg navbar-custom">
            <div class="container">
                <a class="navbar-brand" href="@Url.Action("Index", "Home")">Ampersand Legal</a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav"
                        aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon" style="filter: invert(1);"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarNav">
                    <ul class="navbar-nav ms-auto">
                        <li class="nav-item">
                            <a class="nav-link @(If(ViewContext.RouteData.Values("controller").ToString() = "Home" AndAlso ViewContext.RouteData.Values("action").ToString() = "Index", "active", ""))" href="@Url.Action("Index", "Home")">Home</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link @(If(ViewContext.RouteData.Values("controller").ToString() = "Home" AndAlso ViewContext.RouteData.Values("action").ToString() = "About", "active", ""))" href="@Url.Action("About", "Home")">About</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link @(If(ViewContext.RouteData.Values("controller").ToString() = "PracticeAreas", "active", ""))" href="@Url.Action("Index", "PracticeAreas")">Practice Areas</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link @(If(ViewContext.RouteData.Values("controller").ToString() = "Attorneys", "active", ""))" href="@Url.Action("Index", "Attorneys")">Attorneys</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link @(If(ViewContext.RouteData.Values("controller").ToString() = "Contact", "active", ""))" href="@Url.Action("Index", "Contact")">Contact Us</a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
    </header>

    <main class="content">
        @RenderBody()
    </main>

    <footer class="custom-footer">
        <div class="container">
            <div class="row align-items-start">
                <!-- Logo Placeholder -->
                <div class="col-md-4 mb-3 d-flex flex-column align-items-center">
                    <div class="logo-placeholder">
                        <!-- Replace this div with your logo image -->
                        <!-- Example: <img src="~/images/logo.png" alt="Ampersand Legal" style="max-width: 150px;" /> -->
                    </div>

                    <!-- LinkedIn Icon below logo -->
                    <a href="https://www.linkedin.com/in/abhinav0199" target="_blank" style="margin-top: 10px; color: #0077B5;">
                        <svg xmlns="http://www.w3.org/2000/svg" width="32" height="32" fill="currentColor" viewBox="0 0 16 16">
                            <path d="M0 1.146C0 .513.324 0 .725 0h14.55c.4 0 .725.513.725 1.146v13.708c0 .633-.325 1.146-.725 1.146H.725A.723.723 0 0 1 0 14.854V1.146zm4.943 12.248V6.169H2.542v7.225h2.401zm-1.2-8.207c.837 0 1.355-.554 1.355-1.247-.015-.71-.518-1.246-1.34-1.246-.822 0-1.355.536-1.355 1.246 0 .693.518 1.247 1.327 1.247h.013zm4.908 8.207V9.359c0-.21.015-.42.078-.57.171-.42.563-.854 1.221-.854.862 0 1.207.645 1.207 1.59v3.87h2.4V9.25c0-2.22-1.183-3.252-2.765-3.252-1.276 0-1.845.7-2.165 1.193v.025h-.015a5.15 5.15 0 0 1 .015-.025V6.169h-2.4c.03.67 0 7.225 0 7.225h2.4z" />
                        </svg>
                    </a>
                </div>


                <!-- Contact Info -->
                <div class="col-md-5 mb-3 contact-info">
                    <p>A - 47, Kailash Colony,<br /> New Delhi - 110048, India</p>
                    <p>support@ampersandlegal.in</p>
                    <p>+91 11 45 272 735 &nbsp; <br />&nbsp;+91 74288 40218</p>
                </div>

                <!-- Quick Links and LinkedIn -->
                <div class="col-md-3 mb-3 text-md-end text-start">
                    <div class="mb-2">
                        <a href="@Url.Action("Index", "Home")">Home</a><br />
                        <a href="@Url.Action("About", "Home")">About</a><br />
                        <a href="@Url.Action("Index", "PracticeAreas")">Practice Areas</a><br />
                        <a href="@Url.Action("Index", "Attorneys")">Attorneys</a><br />
                        <a href="@Url.Action("Index", "Contact")">Contact</a>
                    </div>

                </div>
            </div>

            <div class="row">
                <div class="col text-center footer-note">
                    <p>
                        The information provided on this website does not constitute legal advice and is intended for general information purposes only. Accessing this site does not create an attorney-client relationship.
                    </p>
                    <p class="mt-2 mb-0">
                        © @DateTime.Now.Year Ampersand Legal | All rights reserved.
                    </p>
                </div>
            </div>
        </div>
    </footer>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>

    <!-- Cookie Consent Banner -->
    <div id="cookieConsent" style="display:none;position:fixed;bottom:0;width:100%;background:#333;color:#fff;padding:15px;text-align:center;z-index:1000;">
        We use cookies to improve your experience. By using our site, you accept our
        <a href="@Url.Action("Privacy", "Home")" style="color:#4dc3ff;">Privacy Policy</a>.
        <button id="acceptCookies" style="margin-left:15px;padding:5px 10px;background:#4dc3ff;border:none;color:#fff;cursor:pointer;">Accept</button>
    </div>

    <script>
        document.addEventListener("DOMContentLoaded", function () {
            if (!localStorage.getItem('cookiesAccepted')) {
                document.getElementById('cookieConsent').style.display = 'block';
            }

            document.getElementById('acceptCookies').onclick = function () {
                localStorage.setItem('cookiesAccepted', true);
                document.getElementById('cookieConsent').style.display = 'none';
            };
        });
    </script>
    <!-- Disclaimer Modal -->
    <div id="disclaimerModal" style="display:none; position: fixed; z-index: 9999; top:0; left:0; width:100%; height:100%; background: rgba(0,0,0,0.9); color: white; padding: 40px; overflow-y: auto;">
        <div style="max-width: 800px; margin: auto; background: #1e1e1e; padding: 30px; border-radius: 10px;">
            <h2 style="text-align: center; color: #f5c518;">Disclaimer</h2>
            <p style="font-size: 14px; line-height: 1.6;">
                This website is designed solely for the dissemination of basic information about Ampersand Legal. This information is available on the internet, various public platforms, and social media. We have taken care to ensure that the information provided is accurate and up-to-date. However, Ampersand Legal is not responsible for any reliance placed on this information. We will not be liable for any loss or damage caused due to any inaccuracy, exclusion of information, or its interpretation. Readers are advised to verify the information from independent and expert sources.
            </p>
            <p style="font-size: 14px; line-height: 1.6;">
                This website is not an attempt to advertise or solicit clients. It does not seek to create or invite any lawyer-client relationship. The links provided on this website are to facilitate access to basic information about Ampersand Legal and to share our thought leadership initiatives. The content herein or on such links should not be construed as legal reference or legal advice. Readers are advised not to act on any information contained herein or on the links and should refer to legal counsels and experts in their respective jurisdictions for further information and to determine its impact.
            </p>
            <p style="font-size: 14px; line-height: 1.6;">
                Ampersand Legal advises against using the communication platform provided on this website for the exchange of confidential, business, or politically sensitive information. Users are requested to use their judgment and exchange any such information solely at their own risk.
            </p>
            <p style="font-size: 14px; line-height: 1.6;">
                Ampersand Legal uses cookies on its website to improve its usability. By continuing to use our website without changing your privacy settings, you agree to use our cookies.
            </p>
            <div style="text-align: center; margin-top: 30px;">
                <button id="acceptDisclaimer" style="padding: 10px 30px; font-size: 16px; background-color: #28a745; border: none; border-radius: 5px; color: white; margin-right: 20px;">Accept</button>
                <button onclick="window.location.href='https://www.google.com';" style="padding: 10px 30px; font-size: 16px; background-color: #dc3545; border: none; border-radius: 5px; color: white;">Decline</button>
            </div>
        </div>
    </div>

    <script>
        document.addEventListener("DOMContentLoaded", function () {
            if (!localStorage.getItem("disclaimerAccepted")) {
                document.getElementById("disclaimerModal").style.display = "block";
            }

            document.getElementById("acceptDisclaimer").onclick = function () {
                localStorage.setItem("disclaimerAccepted", "true");
                document.getElementById("disclaimerModal").style.display = "none";
            };
        });
    </script>
</body>
</html>
