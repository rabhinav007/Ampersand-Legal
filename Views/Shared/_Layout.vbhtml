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
            background-color: /*#2c2c2c; */#737373;
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

        .nav-link.dynamic-color {
            transition: color 0.3s ease;
        }

            .nav-link.dynamic-color:hover,
            .nav-link.dynamic-color:focus {
                color: #a68a64 !important;
                text-decoration: none;
            }

            .nav-link.dynamic-color.active,
            .nav-link.active {
                font-weight: 600;
                color: #a68a64 !important;
            }

        .btn {
            transition: transform 0.3s ease, box-shadow 0.3s ease;
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
            margin: 40px 0 20px;
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
            background-color: /*#2c2c2c;*/ #737373;
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

        #acceptDisclaimer {
            background-color: #d4af37;
            border: none;
            color: white;
        }

            #acceptDisclaimer:hover {
                background-color: #f1cc66;
                color: #2c2c2c;
            }

        .logo-placeholder {
            background: transparent;
            display: flex;
            align-items: center;
            justify-content: center;
        }

        .logo-3d {
            height: 50px;
            margin-bottom: 4px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.3);
            transform: perspective(500px) rotateX(3deg);
            border-radius: 8px;
            background-color: white;
            padding: 5px;
            transition: all 0.3s ease;
        }

            .logo-3d:hover {
                transform: perspective(500px) rotateX(0deg) scale(1.05);
                box-shadow: 0 6px 12px rgba(0, 0, 0, 0.5);
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

        .whatsapp-float {
            position: fixed;
            bottom: 20px;
            right: 20px;
            z-index: 999;
            background-color: #25D366;
            border-radius: 50px;
            padding: 10px;
            box-shadow: 0 4px 10px rgba(0,0,0,0.3);
            transition: transform 0.3s ease;
        }

            .whatsapp-float:hover {
                transform: scale(1.1);
            }

            .whatsapp-float img {
                width: 20px;
                height: 20px;
            }
        footer.custom-footer a {
            color: white;
            text-decoration: none;
            margin-right: 15px;
            transition: color 0.3s ease;
        }

            footer.custom-footer a:hover {
                text-decoration: underline;
                color: #f7d87c;
            }

            footer.custom-footer a.active-link {
                color: #a68a64 !important;
                text-decoration: underline;
                font-weight: bold;
            }


    </style>
</head>
<body>
    <header>
        <nav class="navbar navbar-expand-lg navbar-custom">
            <div class="container">
                @*<a class="navbar-brand d-flex flex-column align-items-start text-decoration-none" href="@Url.Action("Index", "Home")">
            <img id="site-logo" alt="Ampersand Legal Logo" style="height: 60px; width: 130px" />
            <span id="site-name" class="brand-name">ampersand legal<br><h6>advocates since 1970</h6></span>
        </a>*@
                <a class="navbar-brand d-flex flex-column align-items-center text-decoration-none"
                   href="@Url.Action("Index", "Home")" style="line-height: 1;">

                    <!-- Logo -->
                    <img id="site-logo" alt="Ampersand Legal Logo" style="height: 60px; width: 130px; margin-bottom: 4px;" />

                    <!-- Brand Name -->
                    <span id="site-name" class="brand-name"
                          style="font-weight: bold; font-size: 1.2rem; margin-bottom: 0;">
                        <h2>ampersand legal</h2>
                    </span>

                    <!-- Tagline -->
                    <span id="site-tagline" class="tagline"
                          style="font-size: 0.75rem; margin-top: 0;">
                        <h6>advocates since 1970</h6>
                    </span>
                </a>
                
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav"
                        aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon" style="filter: invert(1);"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarNav">
                    <ul class="navbar-nav ms-auto">
                        <li class="nav-item">
                            <a class="nav-link dynamic-color @(If(ViewContext.RouteData.Values("controller").ToString() = "Home" AndAlso ViewContext.RouteData.Values("action").ToString() = "About", "active", ""))" href="@Url.Action("About", "Home")">about</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link dynamic-color @(If(ViewContext.RouteData.Values("controller").ToString() = "PracticeAreas", "active", ""))" href="@Url.Action("Index", "PracticeAreas")">expertise</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link dynamic-color @(If(ViewContext.RouteData.Values("controller").ToString() = "Attorneys", "active", ""))" href="@Url.Action("Index", "Attorneys")">people</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link dynamic-color @(If(ViewContext.RouteData.Values("controller").ToString() = "Blogs", "active", ""))" href="@Url.Action("Index", "Blogs")">blogs</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link dynamic-color  @(If(ViewContext.RouteData.Values("controller").ToString() = "Contact", "active", ""))" href="@Url.Action("Index", "Contact")">contact us</a>
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
                    <img id="footer-logo" src="/Content/Images/LogoBlack.png"
                         alt="Ampersand Legal Footer Logo"
                         style="max-width: 130px; margin: 0; padding: 0; border: none; background: transparent;" />

                    <div class="d-flex align-items-center" style="gap: 15px; margin-top: 10px;">
                        <!-- LinkedIn -->
                        <!-- LinkedIn -->
                        <a href="https://www.linkedin.com/company/ampersandlegal-in/?viewAsMember=true"
                           target="_blank"
                           style="display: inline-block;">
                            <img src="~/Content/Images/linkedin.png"
                                 alt="LinkedIn"
                                 width="32"
                                 height="32"
                                 style="display: block;" />
                        </a>



                        <!-- WhatsApp -->
                        <a href="https://wa.me/917428840218"
                           target="_blank"
                           aria-label="Chat on WhatsApp">
                            <img src="~/Content/Images/whatsapp.png"
                                 alt="Chat on WhatsApp"
                                  width="32"
                                 height="32"
                                 style="display: block;" />
                        </a>
                    </div>


                </div>

                <div class="col-md-5 mb-3 contact-info">
                    <p>A - 47, Kailash Colony,<br /> New Delhi - 110048, India</p>
                    <p>support@ampersandlegal.in</p>
                    <p>+91 11 45 272 735 <br /> +91 74288 40218</p>
                </div>

                <div class="col-md-3 mb-3 text-md-end text-start">
                    <div class="mb-2">
                        @*<a href="@Url.Action("Index", "Home")">home</a><br />*@
                        @Code
                            Dim currentController = ViewContext.RouteData.Values("controller").ToString().ToLower()
                            Dim currentAction = ViewContext.RouteData.Values("action").ToString().ToLower()
                        End Code

                        <div class="col-md-3 mb-3 text-md-end text-start">
                            <div class="mb-2">
                                <a href="@Url.Action("About", "Home")"
                                   class="@(If(currentController = "home" And currentAction = "about", "active-link", ""))">about</a><br />

                                <a href="@Url.Action("Index", "PracticeAreas")"
                                   class="@(If(currentController = "practiceareas", "active-link", ""))">expertise</a><br />

                                <a href="@Url.Action("Index", "Attorneys")"
                                   class="@(If(currentController = "attorneys", "active-link", ""))">people</a><br />

                                <a href="@Url.Action("Index", "Blogs")"
                                   class="@(If(currentController = "blogs", "active-link", ""))">blogs</a><br />

                                <a href="@Url.Action("Index", "Contact")"
                                   class="@(If(currentController = "contact", "active-link", ""))">contact</a>
                            </div>
                        </div>

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

            <div style="display: flex; justify-content: center; gap: 20px; flex-wrap: wrap; margin-top: 30px;">
                <button id="acceptDisclaimer" style="padding: 10px 30px; font-size: 16px; background-color: #4a4a4a; border: none; border-radius: 5px; color: white; min-width: 120px;">
                    Accept
                </button>
                <button onclick="window.location.href='https://www.google.com';" style="padding: 10px 30px; font-size: 16px; background-color: #7a7a7a; border: none; border-radius: 5px; color: white; min-width: 120px;">
                    Decline
                </button>
            </div>
        </div>
    </div>

    <!-- Scripts -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>


    <script>
        function updateLogosBasedOnNavbar() {
            const navbar = document.querySelector(".navbar");
            const logo = document.getElementById("site-logo");
            const footerLogo = document.getElementById("footer-logo");
            const brandName = document.getElementById("site-name");
            const navLinks = document.querySelectorAll(".nav-link.dynamic-color");

            if (!navbar) return;

            const bgColor = window.getComputedStyle(navbar).backgroundColor;
            const rgbMatch = bgColor.match(/\d+/g);
            if (!rgbMatch) return;

            const rgb = rgbMatch.map(Number);
            const brightness = (rgb[0] * 299 + rgb[1] * 587 + rgb[2] * 114) / 1000;
            const isDark = brightness < 128;

            const logoSrc = isDark
                ? "/Content/Images/LogoWhite.png"
                : "/Content/Images/LogoBlack.png";

            if (logo) logo.src = logoSrc;
            if (footerLogo) footerLogo.src = logoSrc;

            const textColor = isDark ? "#ffffff" : "#000000";
            if (brandName) brandName.style.color = textColor;
            navLinks.forEach(link => link.style.color = textColor);
        }

        document.addEventListener("DOMContentLoaded", function () {
            updateLogosBasedOnNavbar();
            setTimeout(updateLogosBasedOnNavbar, 500); // In case footer/logo loads late
        });

        // Optional: Live theme detection (if you want to handle system theme changes too)
        if (window.matchMedia) {
            window.matchMedia('(prefers-color-scheme: dark)').addEventListener('change', updateLogosBasedOnNavbar);
        }

        // disclaimer 
        window.onload = function () {
            const modal = document.getElementById("disclaimerModal");
            const acceptBtn = document.getElementById("acceptDisclaimer");

            if (!localStorage.getItem("disclaimerAccepted") && modal) {
                modal.style.display = "block";
            }

            if (acceptBtn) {
                acceptBtn.onclick = function () {
                    localStorage.setItem("disclaimerAccepted", "true");
                    modal.style.display = "none";
                };
            }
        };
    </script>





</body>
</html>
