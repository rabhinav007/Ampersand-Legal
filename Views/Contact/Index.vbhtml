<!--@Code ViewBag.Title = "Contact Us" End Code

<h2>Contact Us</h2>
<p>Please fill out the form below to get in touch with us.</p>-->
<!-- Embed Google Form -->
<!--<iframe src="https://forms.gle/y4MG2unYiPpjJpWK9" width="100%" height="600px" frameborder="0"></iframe>-->
<!--@Code ViewBag.Title = "Contact Us" End Code

<section class="contact-section">
    <div class="container">
        <h2>Contact Us</h2>

        <div class="contact-details">
            <h3>For all physical correspondence:</h3>
            <p>
                New Delhi:
                A - 47, Kailash Colony, New Delhi - 110048, India
            </p>

            <h3>For general queries:</h3>
            <p>Email: <a href="mailto:support@ampersandlegal.in">office@ampersandlegal.in</a></p>
            <p>Phone: <a href="cell:+917428840218">+91 74288 40218</a></p>
            <p>Phone: <a href="tel:+911145272735">+91 11-45-272-735</a></p>

            <h3>For recruitment or internship opportunities:</h3>
            <p>Email: <a href="mailto:hr@ampersandlegal.in">hr@ampersandlegal.in</a></p>
        </div>

        <div class="consultation-button">
            <a href="#" class="btn-primary" onclick="openGoogleForm()">Schedule a Consultation</a>
        </div>

        <div id="google-form-container" class="hidden">
            <iframe src="https://forms.gle/y4MG2unYiPpjJpWK9" width="100%" height="600px" frameborder="0"></iframe>
        </div>
    </div>
</section>

<script>function openGoogleForm() {
        document.getElementById("google-form-container").classList.toggle("hidden");
    }</script>-->




@Code
    ViewBag.Title = "Contact Us"
End Code

<section class="contact-section" style="padding: 40px 20px; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; max-width: 800px; margin: auto;">
    <div class="container">
        <h1 style="text-align: center; margin-bottom: 30px; font-weight: 700;">Contact Us</h1>

        <div class="contact-details" style="margin-bottom: 40px;">
            <h2>For all physical correspondence:</h2>
            <address style="font-style: normal; line-height: 1.6; color: #333;">
                <strong>New Delhi Office</strong><br />
                A - 47, Kailash Colony,<br />
                New Delhi - 110048, India
            </address>

            <h2>For general queries:</h2>
            <p>Email: <a href="mailto:support@ampersandlegal.in" style="color: #004aad; text-decoration: none;">support@ampersandlegal.in</a></p>
            <p>Phone: <a href="tel:+911145272735" style="color: #004aad; text-decoration: none;">+91 11 45 272 735</a></p>
            <p>Phone: <a href="tel:+917428840218" style="color: #004aad; text-decoration: none;">+91 74288 40218</a></p>

            <h2>For recruitment or internship opportunities:</h2>
            <p>Email: <a href="mailto:hr@ampersandlegal.in" style="color: #004aad; text-decoration: none;">hr@ampersandlegal.in</a></p>
        </div>

        <div style="text-align: center; margin-bottom: 40px;">
            <button onclick="openGoogleForm()" style="background-color: #004aad; color: white; border: none; padding: 15px 30px; font-size: 1.1rem; cursor: pointer; border-radius: 5px; box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1); transition: background-color 0.3s ease;">
                Schedule a Consultation
            </button>
        </div>

        <div id="google-form-container" class="hidden" style="margin-bottom: 40px;">
            <iframe src="https://forms.gle/y4MG2unYiPpjJpWK9" width="100%" height="600px" frameborder="0" style="border-radius: 8px;"></iframe>
        </div>

        <div style="text-align: center;">
            <!-- Google Maps Embed -->
            <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d14009.338991136717!2d77.22255319124553!3d28.551344883568777!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x390ce21e81b34eeb%3A0x7fa26d28a9a5707f!2sKailash%20Colony%2C%20New%20Delhi!5e0!3m2!1sen!2sin!4v1696380000000!5m2!1sen!2sin"
                    width="100%"
                    height="300"
                    style="border:0; border-radius: 8px;"
                    allowfullscreen=""
                    loading="lazy"
                    referrerpolicy="no-referrer-when-downgrade"
                    aria-label="Office Location Map"></iframe>
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
