@Code
    ViewData("Title") = "About us"
End Code
<style>
    body {
        background-color: #f8f8f8 !important;
    }
    </style>
<section class="about-section" style="padding: 60px 20px; background-color: #f8f8f8; max-width: 900px; margin: auto;">
    <div class="container">
        <h1 style="text-align: center; margin-bottom: 30px;color: #a68a64; font-weight: 700;">About Ampersand Legal</h1>

        <p>
            Ampersand Legal’s objective is to offer a simplified solution to legal services in established areas of law as well as in emerging fields. The firm strives to offer comprehensive yet tailored solutions to its clients, equipped with meticulous research and ingenious methodology.
        </p>

        <p>
            The firm’s endeavour is to assist in bridging the gap between the requirement of the client and the desired result through a holistic, transparent, and cost-effective mechanism.
        </p>

        <p style="margin-top: 40px;">
            <a href="@Url.Action("Index", "Contact")" class="contact-link">
                contact us
            </a>
            to schedule a consultation and learn how Ampersand Legal can assist you.
        </p>


    </div>
</section>
