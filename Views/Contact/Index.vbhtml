@Code
    ViewBag.Title = "Contact Us"
End Code

<style>
    body {
        background-color: #f8f8f8/*#f4f1ea*/ !important;
    }
</style>
<section class="contact-section" style="padding: 40px 20px; background-color: #f8f8f8; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; max-width: 800px; margin: auto;">
    <div class="container" ; style="background-color: #f8f8f8;">
        <h1 style="text-align: center; margin-bottom: 30px;color: #a68a64; font-weight: 700;">Contact Us</h1>

        <div class="contact-details" style="margin-bottom: 40px;">
            <h5>For all physical correspondence:</h5>
            <!-- Make sure Font Awesome is included -->
            <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css">

            <p>
                <i class="fas fa-map-marker-alt" style="color: #a68a64; margin-right: 8px;"></i>
                <span style="color: #004aad;">
                    A - 47, Kailash Colony,<br />
                      New Delhi - 110048, India
                </span>
            </p>


            <h5>For general queries:</h5>           
            <!-- Make sure to include Font Awesome in your <head> -->
            <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css">
            <!-- Contact Info with Icons -->
            <div style="margin-top: 20px;">
                <p>
                    <i class="fas fa-envelope" style="color: #a68a64; margin-right: 8px;"></i>
                    <a href="mailto:support@ampersandlegal.in" style="color: #004aad; text-decoration: none;">
                        support@ampersandlegal.in
                    </a>
                </p>
                <!-- Font Awesome CSS -->
                <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css">

                <!-- Landline Number -->
                <p>
                    <i class="fas fa-phone" style="color: #a68a64; margin-right: 8px;"></i>
                    <a href="tel:+911145272735" style="color: #004aad; text-decoration: none;">
                        +91 11 45 272 735
                    </a>
                </p>

                <!-- Mobile Number -->
                <p>
                    <i class="fas fa-mobile-alt" style="color: #a68a64; margin-right: 8px;"></i>
                    <a href="tel:+917428840218" style="color: #004aad; text-decoration: none;">
                        +91 74288 40218
                    </a>
                </p>

            </div>


            <h5>For recruitment or internship opportunities:</h5>
            <p><i class="fas fa-envelope" style="color: #a68a64; margin-right: 8px;"></i> <a href="mailto:hr@ampersandlegal.in" style="color: #004aad; text-decoration: none;">hr@ampersandlegal.in</a></p>
        </div>

        <div style="text-align: center; margin-bottom: 40px;">
            <button onclick="openGoogleForm()" style="background-color: #a68a64; color: white; border: none; padding: 15px 30px; font-size: 1.1rem; cursor: pointer; border-radius: 5px; box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1); transition: background-color 0.3s ease;">
                Schedule a Consultation
            </button>
        </div>

        <div id="google-form-container" class="hidden" style="margin-bottom: 40px;">
            <iframe src="https://forms.gle/y4MG2unYiPpjJpWK9" width="100%" height="600px" frameborder="0" style="border-radius: 8px;"></iframe>
        </div>

        <div style="text-align: center;">
            <!-- Google Maps Embed -->
            <iframe src="https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d14009.104024217416!2d77.2449434!3d28.5522273!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x390ce3f7031f159d%3A0x625158fa052ca17a!2sAmpersand%20Legal!5e0!3m2!1sen!2sin!4v1718521700000!5m2!1sen!2sin"
                    width="100%"
                    height="300"
                    style="border:0; border-radius: 8px;"
                    allowfullscreen=""
                    loading="lazy"
                    referrerpolicy="no-referrer-when-downgrade"
                    aria-label="Ampersand Legal Map">
            </iframe>
        </div>
    </div>
</section>

<script>
    function openGoogleForm() {
        const container = document.getElementById("google-form-container");
        container.classList.toggle("hidden");
    }
</script>

<style>
    .hidden {
        display: none;
    }
</style>
