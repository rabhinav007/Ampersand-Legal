@Code
    ViewBag.Title = "Contact Us"
End Code

<section class="contact-section" style="padding: 40px 20px; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; max-width: 800px; margin: auto;">
    <div class="container">
        <h1 style="text-align: center; margin-bottom: 30px;color: #a68a64; font-weight: 700;">contact us</h1>

        <div class="contact-details" style="margin-bottom: 40px;">
            <h5>For all physical correspondence:</h5>
            <address style="font-style: normal; line-height: 1.6; color: #333;">
                @*<strong>New Delhi Office</strong><br />*@
                A - 47, Kailash Colony,<br />
                New Delhi - 110048, India
            </address>

            <h5>For general queries:</h5>
            <p>Email: <a href="mailto:support@ampersandlegal.in" style="color: #004aad; text-decoration: none;">support@ampersandlegal.in</a></p>
            <p>Phone: <a href="tel:+911145272735" style="color: #004aad; text-decoration: none;">+91 11 45 272 735</a></p>
            <p>Phone: <a href="tel:+917428840218" style="color: #004aad; text-decoration: none;">+91 74288 40218</a></p>

            <h5>For recruitment or internship opportunities:</h5>
            <p>Email: <a href="mailto:hr@ampersandlegal.in" style="color: #004aad; text-decoration: none;">hr@ampersandlegal.in</a></p>
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
