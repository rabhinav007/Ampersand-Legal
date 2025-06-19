@Code
    Layout = Nothing
End Code

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>@ViewData("Title") - Ampersand Legal</title>

    <link rel="stylesheet" href="~/Content/site.css" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />

    <style>
        .navbar-custom {
            background-color: #2c2c2c;
        }

            .navbar-custom .navbar-brand,
            .navbar-custom .nav-link {
                color: #ffffff;
            }

        .navbar-brand {
            font-family: 'Yeseva One', serif !important;
            font-size: 28px;
            letter-spacing: 0.5px;
        }

        .navbar-custom .nav-link:hover,
        .navbar-custom .nav-link:focus {
            color: #d4af37;
        }

        .nav-link.active {
            font-weight: bold;
            color: #d4af37 !important;
        }

        .btn {
            transition: transform 0.3s ease, box-shadow 0.3s ease;
            display: inline-block;
            text-align: center;
            text-decoration: none;
        }

            .btn:hover {
                transform: scale(1.05);
                box-shadow: 0 4px 12px rgba(166, 138, 100, 0.4);
            }


        .hover-card {
            transition: transform 0.3s ease, box-shadow 0.3s ease;
            background-color: #fdfdfd;
            border: 1px solid #ddd;
            border-radius: 8px;
        }

            .hover-card:hover {
                transform: translateY(-5px);
                box-shadow: 0 6px 20px rgba(0, 0, 0, 0.1);
                z-index: 1;
            }


        .section-heading {
            background-color: #a68a64;
            border-left: 5px solid #007bff;
            padding: 10px 20px;
            margin-top: 40px;
            margin-bottom: 20px;
            font-weight: bold;
            font-size: 1.5rem;
        }

        .team-card {
            display: flex;
            background: #fff;
            border-radius: 10px;
            box-shadow: 0 2px 6px rgba(0, 0, 0, 0.1);
            padding: 20px;
            margin-bottom: 20px;
            align-items: flex-start;
            transition: all 0.3s ease;
            border: 1px solid #eee;
        }

            .team-card:hover {
                transform: translateY(-5px);
                box-shadow: 0 8px 20px rgba(0, 0, 0, 0.15);
                border-color: #a68a64;
            }

            .team-card img {
                width: 300px;
                height: 200px;
                object-fit: cover;
                border-radius: 5px;
                margin-right: 20px;
            }

            .team-card h4 {
                margin-bottom: 5px;
                text-transform: capitalize;
            }

            .team-card h6 {
                margin-bottom: 10px;
                text-transform: lowercase;
            }

        footer.custom-footer {
            background-color: #2c2c2c;
            color: #f5f5f5;
            padding: 40px 0;
            font-size: 15px;
        }

            footer.custom-footer a {
                color: #d4af37;
                text-decoration: none;
                margin-right: 15px;
            }

                footer.custom-footer a:hover {
                    text-decoration: underline;
                    color: #f7d87c;
                }

            footer.custom-footer .logo-placeholder {
                width: 100px;
                height: 50px;
                background-color: white;
                border-radius: 8px;
            }

            footer.custom-footer .contact-info p {
                margin-bottom: 8px;
            }

            footer.custom-footer .footer-note {
                font-size: 13px;
                color: #aaaaaa;
                margin-top: 30px;
            }

            footer.custom-footer svg {
                vertical-align: middle;
                fill: #d4af37;
            }

        
        .practice-card {
            transition: transform 0.3s ease, box-shadow 0.3s ease;
        }

        .practice-card:hover {
            transform: scale(1.35);
            box-shadow: 0 4px 16px #a68a64;
            z-index: 1;
            position: relative;
        }

        .contact-link {
            text-decoration: underline;
            color: #a68a64;
            font-weight: 500;
            transition: color 0.3s ease, transform 0.3s ease, text-shadow 0.3s ease;
        }

            .contact-link:hover {
                color: #7c6142;
                font-weight: 600;
                transform: scale(1.10);
                text-shadow: 0 1px 4px rgba(166, 138, 100, 0.4);
            }
    


        .content {
            padding-top: 0 !important;
            margin-top: 0 !important;
        }

        #cookieConsent {
            background: #2c2c2c;
        }

        #acceptCookies {
            background-color: #d4af37;
            border: none;
            color: white;
        }

            #acceptCookies:hover {
                background-color: #f1cc66;
                color: #2c2c2c;
            }

        #acceptDisclaimer {
            background-color: #d4af37;
            border: none;
            color: white;
        }

            #acceptDisclaimer:hover {
                background-color: #f1cc66;
                color: #2c2c2c;
            }
    </style>
</head>
<body>
    <header>
        <nav class="navbar navbar-expand-lg navbar-custom">
            <div class="container">
                <a class="navbar-brand d-flex flex-column align-items-start text-decoration-none" href="@Url.Action("Index", "Home")">
                    <img src="~/Content/images/Logo.jpg" alt="Ampersand Legal Logo" style="height: 50px; margin-bottom: 4px;" />
                    <span style="color: white;">ampersand legal</span>
                </a>
                @*<p style="font-size: 20px; font-style: italic; text-decoration: underline; color: #59554c;">advocates since 1970</p>*@
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav"
                        aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon" style="filter: invert(1);"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarNav">
                    <ul class="navbar-nav ms-auto">
                        <li class="nav-item">
                            <a class="nav-link @(If(ViewContext.RouteData.Values("controller").ToString() = "Home" AndAlso ViewContext.RouteData.Values("action").ToString() = "About", "active", ""))" href="@Url.Action("About", "Home")">about</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link @(If(ViewContext.RouteData.Values("controller").ToString() = "PracticeAreas", "active", ""))" href="@Url.Action("Index", "PracticeAreas")">practice areas</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link @(If(ViewContext.RouteData.Values("controller").ToString() = "Attorneys", "active", ""))" href="@Url.Action("Index", "Attorneys")">team</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link @(If(ViewContext.RouteData.Values("controller").ToString() = "Contact", "active", ""))" href="@Url.Action("Index", "Contact")">contact us</a>
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
                <div class="col-md-4 mb-3 d-flex flex-column align-items-center">
                    <div class="logo-placeholder">
                        <img src="~/Content/images/Logo.jpg" alt="Ampersand Legal" style="max-width: 100px;" />
                    </div>
                    <a href="https://www.linkedin.com/in/abhinav0199" target="_blank" style="margin-top: 10px; color: #0077B5;">
                        <svg xmlns="http://www.w3.org/2000/svg" width="32" height="32" fill="currentColor" viewBox="0 0 16 16">
                            <path d="M0 1.146C0 .513.324 0 .725 0h14.55c.4 0 .725.513.725 1.146v13.708c0 .633-.325 1.146-.725 1.146H.725A.723.723 0 0 1 0 14.854V1.146zm4.943 12.248V6.169H2.542v7.225h2.401zm-1.2-8.207c.837 0 1.355-.554 1.355-1.247-.015-.71-.518-1.246-1.34-1.246-.822 0-1.355.536-1.355 1.246 0 .693.518 1.247 1.327 1.247h.013zm4.908 8.207V9.359c0-.21.015-.42.078-.57.171-.42.563-.854 1.221-.854.862 0 1.207.645 1.207 1.59v3.87h2.4V9.25c0-2.22-1.183-3.252-2.765-3.252-1.276 0-1.845.7-2.165 1.193v.025h-.015a5.15 5.15 0 0 1 .015-.025V6.169h-2.4c.03.67 0 7.225 0 7.225h2.4z" />
                        </svg>
                    </a>
                </div>

                <div class="col-md-5 mb-3 contact-info">
                    <p>A - 47, Kailash Colony,<br /> New Delhi - 110048, India</p>
                    <p>support@ampersandlegal.in</p>
                    <p>+91 11 45 272 735 <br /> +91 74288 40218</p>
                </div>

                <div class="col-md-3 mb-3 text-md-end text-start">
                    <div class="mb-2">
                        <a href="@Url.Action("Index", "Home")">home</a><br />
                        <a href="@Url.Action("About", "Home")">about</a><br />
                        <a href="@Url.Action("Index", "PracticeAreas")">practice areas</a><br />
                        <a href="@Url.Action("Index", "Attorneys")">team</a><br />
                        <a href="@Url.Action("Index", "Contact")">contact</a>
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="col text-center footer-note">
                    <p>
                        The information provided on this website does not constitute legal advice and is intended for general information purposes only. Accessing this site does not create an attorney-client relationship.
                    </p>
                    <p class="mt-2 mb-0">
                        © @DateTime.Now.Year Ampersand Legal |&nbsp;ampersandlegal.in | All rights reserved.
                    </p>
                </div>
            </div>
        </div>
    </footer>

    <!-- Disclaimer Modal -->
    <div id="disclaimerModal" style="display:none; position: fixed; z-index: 9999; top:0; left:0; width:100%; height:100%; background: rgba(255,255,255,0.95); color: #333; padding: 40px; overflow-y: auto;">
        <div style="max-width: 800px; margin: auto; background: #f9f6f2; padding: 30px; border-radius: 10px; box-shadow: 0 0 15px rgba(0,0,0,0.2);">
            <h2 style="text-align: center; color: #6c584c; font-family: 'Yeseva One', serif;">Disclaimer</h2>
            
            <p style="font-size: 14px; line-height: 1.7; color: #444;">
                This website is designed solely for the dissemination of basic information about Ampersand Legal. This information is available on the internet, various public platforms, and social media. We have taken care to ensure that the information provided is accurate and up-to-date. However, Ampersand Legal is not responsible for any reliance placed on this information. We will not be liable for any loss or damage caused due to any inaccuracy, exclusion of information, or its interpretation. Readers are advised to verify the information from independent and expert sources.
            </p>
            <p style="font-size: 14px; line-height: 1.7; color: #444;">
                This website is not an attempt to advertise or solicit clients. It does not seek to create or invite any lawyer-client relationship. The links provided on this website are to facilitate access to basic information about Ampersand Legal and to share our thought leadership initiatives. The content herein or on such links should not be construed as legal reference or legal advice. Readers are advised not to act on any information contained herein or on the links and should refer to legal counsels and experts in their respective jurisdictions for further information and to determine its impact.
            </p>
            <p style="font-size: 14px; line-height: 1.7; color: #444;">
                Ampersand Legal advises against using the communication platform provided on this website for the exchange of confidential, business, or politically sensitive information. Users are requested to use their judgment and exchange any such information solely at their own risk.
            </p>
            
            <div style="text-align: center; margin-top: 30px;">
                <button id="acceptDisclaimer" style="padding: 10px 30px; font-size: 16px; background-color: #4a4a4a; border: none; border-radius: 5px; color: white; margin-right: 20px;">
                    Accept
                </button>
                <button onclick="window.location.href='https://www.google.com';" style="padding: 10px 30px; font-size: 16px; background-color: #7a7a7a; border: none; border-radius: 5px; color: white;">
                    Decline
                </button>
            </div>
        </div>
    </div>

    <!-- Scripts -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>

    <!-- Disclaimer Modal Script -->
    <script>
        window.onload = function () {
            try {
                var modal = document.getElementById("disclaimerModal");
                var acceptBtn = document.getElementById("acceptDisclaimer");

                if (!localStorage.getItem("disclaimerAccepted") && modal && acceptBtn) {
                    modal.style.display = "block";
                    acceptBtn.onclick = function () {
                        localStorage.setItem("disclaimerAccepted", "true");
                        modal.style.display = "none";
                    };
                }
            } catch (err) {
                console.error("Disclaimer Modal Error:", err);
            }
        };
    </script>
</body>
</html>
