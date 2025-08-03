@Code
    ViewData("Title") = "Home"
End Code

<style>
    .hover-card {
        transition: transform 0.3s ease, box-shadow 0.3s ease;
        background-color: #fdfdfd;
        border: 1px solid #ddd;
        border-radius: 8px;
    }

        .hover-card:hover {
            transform: translateY(-5px);
            box-shadow: 0 6px 20px rgba(0, 0, 0, 0.11);
            z-index: 1;
        }


    .about-animation {
        text-align: center;
        animation: float 6s ease-in-out infinite;
        margin-top: 30px;
    }


    .about-animation {
        text-align: center;
        animation: float 6s ease-in-out infinite;
        margin-top: 30px;
    }
</style>

<!-- hero section -->
<div style="background-color: #f8f8f8; color: #3b3b3b; padding: 70px 0 60px 0; text-align: center; font-family: 'Georgia', serif;">
    <h4 style="font-size: 58px; font-family: 'Yeseva One'; font-weight: 700;">Welcome to Ampersand Legal</h4>
    <h5 style="margin-top: 10px; color: #4b433f; text-align: justify; line-height: 2; font-family: 'Yeseva One', serif; padding-left: 1.5em; padding-right: 1.5em;">
        Etymologically derived from the Latin word “et” meaning “and,” Ampersand is a distortion of its original usage, i.e. “and per se and.” Over the years, the conjunctive punctuation has undergone many iterations and is now commonly used in its present form as “&.”
        Deriving its meaning from the same, Ampersand Legal strives at synchronizing and bridging the gap between the client’s expectations and their requirements along with aligning and balancing things amidst the process.
    </h5>

</div>

<!-- about section -->
<section style="padding: 60px 0; background-color: #f8f8f8;">
    <div class="container" style="display: flex; flex-wrap: wrap; align-items: center; gap: 30px;">

        <!-- Text Column -->
        <div style="flex: 1; padding: 10px;">
            <h2 style="font-size: 28px; font-weight: 600; margin-bottom: 15px;">
                <span style="color: #a68a64; font-family: 'Yeseva One', serif;">About Ampersand Legal</span>
            </h2>
            <p style="color: #4b433f; font-size: 18px; line-height: 1.7; font-family: 'Yeseva One' ">
                With decades of experience, our firm has successfully represented thousands of clients in complex legal matters.<br />
                We are committed to providing strategic and results-driven legal solutions.
            </p>
            <a href="@Url.Action("About", "Home")" class="btn" style="margin-top: 20px; margin-right: 15px; padding: 10px 24px; background-color: #a68a64; color: white; border: none; border-radius: 4px;">
                Learn More
            </a>
            <a href="@Url.Action("Index", "Contact")" class="btn" style="margin-top: 20px; padding: 10px 25px; background-color: #a68a64; color: white; border: none; border-radius: 4px;">
                Schedule a Consultation
            </a>


        </div>
    </div>
</section>

<!-- practice areas -->
<section style="padding: 50px 0; background-color: #f8f8f8;">
    <div class="container">
        <h2 style="text-align: center; margin-bottom: 40px; color: #2c2c2c;">Our Practice Areas</h2>

        <div style="display: flex; flex-wrap: wrap; gap: 20px; justify-content: space-between;">

            <!-- civil law -->
            <!--<div class="practice-card hover-card" style="flex: 1 1 22%; min-width: 220px; text-align: center; background-color: #ffffff; border-radius: 10px; padding: 15px; box-shadow: 0 2px 8px #b5a893;">-->
            @*<div style="flex: 1 1 22%; min-width: 220px; text-align: center; background-color: #ffffff; border-radius: 10px; padding: 15px; box-shadow: 0 2px 8px #b5a893;">*@
            <!--<img src="~/Content/images/family-law.jpg" alt="family law" style="width: 100%; max-width: 200px; border-radius: 6px;" />
        <h4 style="margin-top: 15px; color: #4b433f;">Civil Law</h4>
        <p style="font-size: 14px; color: #59554c;">Helping families navigate disputes and protect civil rights.</p>
    </div>-->
            <a href="@Url.Action("Index", "PracticeAreas")#civil-law" class="practice-card hover-card" style="flex: 1 1 22%; min-width: 220px; text-align: center; background-color: #ffffff; border-radius: 10px; padding: 15px; box-shadow: 0 2px 8px #b5a893; text-decoration: none;">
                <h4 style="margin-top: 15px; color: #4b433f;">Civil Law</h4>
                <p style="font-size: 14px; color: #59554c;">Helping families navigate disputes and protect civil rights.</p>
            </a>



            <!-- corporate law -->
            <!--<div class="practice-card hover-card" style="flex: 1 1 22%; min-width: 220px; text-align: center; background-color: #ffffff; border-radius: 10px; padding: 15px; box-shadow: 0 2px 8px #b5a893;">-->
            @*<div style="flex: 1 1 22%; min-width: 220px; text-align: center; background-color: #ffffff; border-radius: 10px; padding: 15px; box-shadow: 0 2px 8px #b5a893;">*@
            @*<img src="~/Content/images/business-law.jpg" alt="corporate law" style="width: 100%; max-width: 200px; border-radius: 6px;" />*@
            <!--<h4 style="margin-top: 15px; color: #4b433f;">Corporate Law</h4>
        <p style="font-size: 14px; color: #59554c;">Business Compliance, Contracts, and Advisory services.</p>
    </div>-->
            <a href="@Url.Action("Index", "PracticeAreas")#corporate-law" class="practice-card hover-card" style="flex: 1 1 22%; min-width: 220px; text-align: center; background-color: #ffffff; border-radius: 10px; padding: 15px; box-shadow: 0 2px 8px #b5a893; text-decoration: none;">
                <h4 style="margin-top: 15px; color: #4b433f;">Corporate Law</h4>
                <p style="font-size: 14px; color: #59554c;">Business Compliance, Contracts, and Advisory services.</p>
            </a>


            <!-- criminal law -->
            <!--<div class="practice-card hover-card" style="flex: 1 1 22%; min-width: 220px; text-align: center; background-color: #ffffff; border-radius: 10px; padding: 15px; box-shadow: 0 2px 8px #b5a893;">-->
            @*<div style="flex: 1 1 22%; min-width: 220px; text-align: center; background-color: #ffffff; border-radius: 10px; padding: 15px; box-shadow: 0 2px 8px #b5a893;">*@
            @*<img src="~/Content/images/criminal-defence.jpg" alt="criminal law" style="width: 100%; max-width: 200px; border-radius: 6px;" />*@
            <!--<h4 style="margin-top: 15px; color: #4b433f;">Criminal Law</h4>
        <p style="font-size: 14px; color: #59554c;">Defending clients in Criminal trials and Investigations.</p>
    </div>-->
            <a href="@Url.Action("Index", "PracticeAreas")#criminal-law" class="practice-card hover-card" style="flex: 1 1 22%; min-width: 220px; text-align: center; background-color: #ffffff; border-radius: 10px; padding: 15px; box-shadow: 0 2px 8px #b5a893; text-decoration: none;">
                <h4 style="margin-top: 15px; color: #4b433f;">Criminal Law</h4>
                <p style="font-size: 14px; color: #59554c;">Defending clients in Criminal trials and Investigations.</p>
            </a>

            <!-- cross-border -->
            <!--<div class="practice-card hover-card" style="flex: 1 1 22%; min-width: 220px; text-align: center; background-color: #ffffff; border-radius: 10px; padding: 15px; box-shadow: 0 2px 8px #b5a893;">-->
            @*<div style="flex: 1 1 22%; min-width: 220px; text-align: center; background-color: #ffffff; border-radius: 10px; padding: 15px; box-shadow: 0 2px 8px #b5a893;">*@
            @*<img src="~/Content/images/Cross-Border.jpg" alt="cross border" style="width: 100%; max-width: 200px; border-radius: 6px;" />*@
            <!--<h4 style="margin-top: 15px; color: #4b433f;">Cross-Border</h4>
        <p style="font-size: 14px; color: #59554c;">Expertise in International law, Transactions, and Disputes.</p>
    </div>-->
            <a href="@Url.Action("Index", "PracticeAreas")#cross-border" class="practice-card hover-card" style="flex: 1 1 22%; min-width: 220px; text-align: center; background-color: #ffffff; border-radius: 10px; padding: 15px; box-shadow: 0 2px 8px #b5a893; text-decoration: none;">
                <h4 style="margin-top: 15px; color: #4b433f;">International Law</h4>
                <p style="font-size: 14px; color: #59554c;">Expertise in International law, Transactions, and Disputes.</p>
            </a>

        </div>
    </div>
</section>