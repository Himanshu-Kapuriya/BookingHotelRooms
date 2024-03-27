
var bregister = document.getElementById("t_btn2");
bregister.addEventListener("click", loginPage);
function loginPage() {
    cosole.log("m")
    // window.location.href="./loveLetters"  // Ravi_Booking.com/Booking sign.html    ../main page/Booking sign.html
}
function citySearch() {
    var data = document.querySelector("#t_sear1").value
    var data = data.toLowerCase()

    window.location.href = `${data}.html`
}


const landing_accordion = document.getElementsByClassName("landing_covidInfo_accordion");

for (let i = 0; i < landing_accordion.length; i++) {
    landing_accordion[i].addEventListener("click", function () {
        this.classList.toggle("landing_covidInfo_list_active");
        var panel = this.nextElementSibling;
        if (panel.style.display === "block") {
            panel.style.display = "none";
        }
        else {
            panel.style.display = "block";
        }
    });
}

function countryBtn1() {
    var usa_img1 = document.querySelector('#t_dis_usa1')
    var country_name1 = document.querySelector('#t_country_name1')
    var usa_text1 = document.querySelector('#t_usa_hov1')

    usa_img1.style.backgroundImage = "url('https://www.planetware.com/photos-large/USNY/usa-best-places-new-york.jpg')"
    country_name1.textContent = ' America'
    usa_text1.textContent = 'You will love relaxation, restaurants and shopping during your next trip to United States of America!'

    var usa_img2 = document.querySelector('#t_dis_usa2')
    var country_name2 = document.querySelector('#t_country_name2')
    var usa_text2 = document.querySelector('#t_usa_hov2')

    usa_img2.style.backgroundImage = "url('https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTwP72udXhadoC45fH_QxdDiBse-TbtBWt3nQ&usqp=CAU')"
    country_name2.textContent = 'Italy'
    usa_text2.textContent = 'You will love old town,  scenery and food during your next trip to Italy!'

    var usa_img3 = document.querySelector('#t_dis_usa3')
    var country_name3 = document.querySelector('#t_country_name3')
    var usa_text3 = document.querySelector('#t_usa_hov3')

    usa_img3.style.backgroundImage = "url('https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTss3zIAgbicdSFkD8Wh6LvCXzMf6N2luAsCA&usqp=CAU')"
    country_name3.textContent = 'France'
    usa_text3.textContent = 'Put tranquillity,  scenery and old town on your to-do list for your next trip to France!'

    var usa_img4 = document.querySelector('#t_dis_usa4')
    var country_name4 = document.querySelector('#t_country_name4')
    var usa_text4 = document.querySelector('#t_usa_hov4')

    usa_img4.style.backgroundImage = "url('https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSxYxM0Cj4Xplcdzd-gJA6zvGLVE-VvN7FicQ&usqp=CAU')"
    country_name4.textContent = 'Spain'
    usa_text4.textContent = 'If tranquillity,   old town and food are  your thing, don’t miss out  on Spain!'

    var usa_img5 = document.querySelector('#t_dis_usa5')
    var country_name5 = document.querySelector('#t_country_name5')
    var usa_text5 = document.querySelector('#t_usa_hov5')

    usa_img5.style.backgroundImage = "url('https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS8chu3ll2ZqMpzHnyT-1-BFnwKgxSfjaDy8Q&usqp=CAU')"
    country_name5.textContent = 'Germany'
    usa_text5.textContent = 'Don’t miss out on Germany! Top destination for old town, walking and city walks. '

}
function countryBtn2() {
    var usa_img1 = document.querySelector('#t_dis_usa1')
    var country_name1 = document.querySelector('#t_country_name1')
    var usa_text1 = document.querySelector('#t_usa_hov1')

    usa_img1.style.backgroundImage = "url('https://static.toiimg.com/photo/80742236.cms')"
    country_name1.textContent = 'United Kingdom'
    usa_text1.textContent = 'Try United Kingdom for your next trip! Enjoy shopping, scenery and sightseeing while you’re there!'

    var usa_img2 = document.querySelector('#t_dis_usa2')
    var country_name2 = document.querySelector('#t_country_name2')
    var usa_text2 = document.querySelector('#t_usa_hov2')

    usa_img2.style.backgroundImage = "url('https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRjR4Ch6OaqUB0JEt_9ppnyMtR31VwWzD4U3Q&usqp=CAU')"
    country_name2.textContent = 'Russia'
    usa_text2.textContent = 'Russia is highly rated by travelers for city walks, sightseeing and architecture.'

    var usa_img3 = document.querySelector('#t_dis_usa3')
    var country_name3 = document.querySelector('#t_country_name3')
    var usa_text3 = document.querySelector('#t_usa_hov3')

    usa_img3.style.backgroundImage = "url('https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSqDpVORTuEF-7_5GvnQPFSw3q3eOW-2JSGfw&usqp=CAU')"
    country_name3.textContent = 'Croatia'
    usa_text3.textContent = 'Croatia is highly rated by travelers for oceanside, relaxation and old town.'

    var usa_img4 = document.querySelector('#t_dis_usa4')
    var country_name4 = document.querySelector('#t_country_name4')
    var usa_text4 = document.querySelector('#t_usa_hov4')

    usa_img4.style.backgroundImage = "url('https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS2GwCyyMxdEV03lgVeEUZvJo5bBBwJQqTiQg&usqp=CAU')"
    country_name4.textContent = 'Brazil'
    usa_text4.textContent = 'Put tranquillity, nature and beaches on your to-do list for your next trip to Brazil!'

    var usa_img5 = document.querySelector('#t_dis_usa5')
    var country_name5 = document.querySelector('#t_country_name5')
    var usa_text5 = document.querySelector('#t_usa_hov5')

    usa_img5.style.backgroundImage = "url('https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ0CRvWlhClFp6KidDqmyuLWTzCQAFYx2Fl4A&usqp=CAU')"
    country_name5.textContent = ' India'
    usa_text5.textContent = 'Relaxation, sightseeing and temples are just a few reasons why travelers enjoy India.'

}

function countryBtn3() {
    var usa_img1 = document.querySelector('#t_dis_usa1')
    var country_name1 = document.querySelector('#t_country_name1')
    var usa_text1 = document.querySelector('#t_usa_hov1')

    usa_img1.style.backgroundImage = "url('https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTvTGSUZxFJsD5MQNi55VlpY_OvkKe54pXpVw&usqp=CAU')"
    country_name1.textContent = 'Greece'
    usa_text1.textContent = 'Relaxation, beaches and food are just a few reasons why travelers enjoy Greece.'

    var usa_img2 = document.querySelector('#t_dis_usa2')
    var country_name2 = document.querySelector('#t_country_name2')
    var usa_text2 = document.querySelector('#t_usa_hov2')

    usa_img2.style.backgroundImage = "url('https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTRtrBIXkbXT3Yl9QZWU7OSra6Ido9PLnUiEA&usqp=CAU')"
    country_name2.textContent = 'Poland'
    usa_text2.textContent = 'If old town, walking and city walks are your thing, don’t miss out on Poland!'

    var usa_img3 = document.querySelector('#t_dis_usa3')
    var country_name3 = document.querySelector('#t_country_name3')
    var usa_text3 = document.querySelector('#t_usa_hov3')

    usa_img3.style.backgroundImage = "url('https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTD3Kg6pDOGJrNjvqDP4qrO4p02jAEuMiyAUw&usqp=CAU')"
    country_name3.textContent = 'Japan'
    usa_text3.textContent = 'Don’t miss out on Japan! Top destination for food, sightseeing and scenery.'

    var usa_img4 = document.querySelector('#t_dis_usa4')
    var country_name4 = document.querySelector('#t_country_name4')
    var usa_text4 = document.querySelector('#t_usa_hov4')

    usa_img4.style.backgroundImage = "url('https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSQevwcl2CVwmn7WKWQu8UKVauXw7LswphvAA&usqp=CAU')"
    country_name4.textContent = 'South Africa'
    usa_text4.textContent = 'You will love relaxation, scenery and nature during your next trip to South Africa!'

    var usa_img5 = document.querySelector('#t_dis_usa5')
    var country_name5 = document.querySelector('#t_country_name5')
    var usa_text5 = document.querySelector('#t_usa_hov5')

    usa_img5.style.backgroundImage = "url('https://static.independent.co.uk/s3fs-public/thumbnails/image/2018/02/21/12/lisbon-skyline.jpg?width=1200')"
    country_name5.textContent = 'Portugal'
    usa_text5.textContent = 'If old town, tranquillity and scenery are your thing, don’t miss out on Portugal!'

}

function countryBtn4() {
    var usa_img1 = document.querySelector('#t_dis_usa1')
    var country_name1 = document.querySelector('#t_country_name1')
    var usa_text1 = document.querySelector('#t_usa_hov1')

    usa_img1.style.backgroundImage = "url('https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSgC2D1nfF5fM9gc1gr-eRwBUPYZOqpW8kJvg&usqp=CAU')"
    country_name1.textContent = 'Australia'
    usa_text1.textContent = 'You will love relaxation, scenery and beaches during your next trip to Australia!'

    var usa_img2 = document.querySelector('#t_dis_usa2')
    var country_name2 = document.querySelector('#t_country_name2')
    var usa_text2 = document.querySelector('#t_usa_hov2')

    usa_img2.style.backgroundImage = "url('https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQcKQTz7bOXbBzs4SPsQlmExiQ6CEcZgplUwA&usqp=CAU')"
    country_name2.textContent = 'Austria'
    usa_text2.textContent = 'Put nature, mountains and scenery on your to-do list for your next trip to Austria!'

    var usa_img3 = document.querySelector('#t_dis_usa3')
    var country_name3 = document.querySelector('#t_country_name3')
    var usa_text3 = document.querySelector('#t_usa_hov3')

    usa_img3.style.backgroundImage = "url('https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSySY6LMvhr01rGVmkYUFpeq6nGbBwA8LRDUg&usqp=CAU')"
    country_name3.textContent = 'Thailand'
    usa_text3.textContent = 'Travelers choose Thailand for relaxation, food and beaches.'

    var usa_img4 = document.querySelector('#t_dis_usa4')
    var country_name4 = document.querySelector('#t_country_name4')
    var usa_text4 = document.querySelector('#t_usa_hov4')

    usa_img4.style.backgroundImage = "url('https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSAsjAtbUISw9GUz53Joi9hE-85ftVbexYauQ&usqp=CAU')"
    country_name4.textContent = 'China'
    usa_text4.textContent = 'China – the ideal getaway for food, sightseeing and culture!'

    var usa_img5 = document.querySelector('#t_dis_usa5')
    var country_name5 = document.querySelector('#t_country_name5')
    var usa_text5 = document.querySelector('#t_usa_hov5')

    usa_img5.style.backgroundImage = "url('https://gotra.sgp1.cdn.digitaloceanspaces.com/web-upload/1591672895-09-06-2020-WDKFRfmVrwxqi6Thp9a4IJLkXuPolQc8.jpg')"
    country_name5.textContent = 'Indonesia'
    usa_text5.textContent = 'Put relaxation, food and beaches on your to-do list for your next trip to Indonesia!'

}

function countryBtn5() {
    var usa_img1 = document.querySelector('#t_dis_usa1')
    var country_name1 = document.querySelector('#t_country_name1')
    var usa_text1 = document.querySelector('#t_usa_hov1')

    usa_img1.style.backgroundImage = "url('https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQBi1_NY_b22mgCQOjmOemMFmNbUrxXnGG9tA&usqp=CAU')"
    country_name1.textContent = 'Argentina'
    usa_text1.textContent = 'Argentina – the ideal getaway for tranquillity, scenery and nature!'

    var usa_img2 = document.querySelector('#t_dis_usa2')
    var country_name2 = document.querySelector('#t_country_name2')
    var usa_text2 = document.querySelector('#t_usa_hov2')

    usa_img2.style.backgroundImage = "url('https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQPiHzq6Jc8ldVE8PFgGT0PzXy72fQPNoCBtg&usqp=CAU')"
    country_name2.textContent = 'Mexico'
    usa_text2.textContent = 'Mexico is a great choice for travelers interested in food, friendly locals and tranquillity.'

    var usa_img3 = document.querySelector('#t_dis_usa3')
    var country_name3 = document.querySelector('#t_country_name3')
    var usa_text3 = document.querySelector('#t_usa_hov3')

    usa_img3.style.backgroundImage = "url('https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSqDpVORTuEF-7_5GvnQPFSw3q3eOW-2JSGfw&usqp=CAU')"
    country_name3.textContent = 'Canada'
    usa_text3.textContent = 'Put scenery, nature and restaurants on your to-do list for your next trip to Canada!'

    var usa_img4 = document.querySelector('#t_dis_usa4')
    var country_name4 = document.querySelector('#t_country_name4')
    var usa_text4 = document.querySelector('#t_usa_hov4')

    usa_img4.style.backgroundImage = "url('https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSxZ3mro5UnJQ9EXZGaFR_b7EG8ZOHIrDrMiQ&usqp=CAU')"
    country_name4.textContent = 'Vietnam'
    usa_text4.textContent = 'Vietnam – the ideal getaway for food, friendly locals and local food!'

    var usa_img5 = document.querySelector('#t_dis_usa5')
    var country_name5 = document.querySelector('#t_country_name5')
    var usa_text5 = document.querySelector('#t_usa_hov5')

    usa_img5.style.backgroundImage = "url('https://www.euractiv.com/wp-content/uploads/sites/2/2020/04/Georgia-flags-800x450.jpg')"
    country_name5.textContent = 'Georgia'
    usa_text5.textContent = 'Georgia is a great choice for travelers interested in friendly locals, nature and local food.'

}

function countryBtn6() {
    var usa_img1 = document.querySelector('#t_dis_usa1')
    var country_name1 = document.querySelector('#t_country_name1')
    var usa_text1 = document.querySelector('#t_usa_hov1')

    usa_img1.style.backgroundImage = "url('https://media.tacdn.com/media/attractions-splice-spp-674x446/06/75/b2/9a.jpg')"
    country_name1.textContent = 'Romania'
    usa_text1.textContent = 'Don’t miss out on Romania! Top destination for relaxation, old town and scenery.'

    var usa_img2 = document.querySelector('#t_dis_usa2')
    var country_name2 = document.querySelector('#t_country_name2')
    var usa_text2 = document.querySelector('#t_usa_hov2')

    usa_img2.style.backgroundImage = "url('https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcThz_We-P6GRZxExwgqUI_6CdcKekU-ycpvdA&usqp=CAU')"
    country_name2.textContent = 'Netherlands'
    usa_text2.textContent = 'Walking, city walks and cycling are just a few reasons why you’ll love Netherlands.'

    var usa_img3 = document.querySelector('#t_dis_usa3')
    var country_name3 = document.querySelector('#t_country_name3')
    var usa_text3 = document.querySelector('#t_usa_hov3')

    usa_img3.style.backgroundImage = "url('http://ttgasia.2017.ttgasia.com/wp-content/uploads/sites/2/2020/05/Petronas-Twin-Towers-in-Kuala-Lumpur.jpg')"
    country_name3.textContent = 'Malaysia'
    usa_text3.textContent = 'Malaysia – the ideal getaway for relaxation, food and shopping!'

    var usa_img4 = document.querySelector('#t_dis_usa4')
    var country_name4 = document.querySelector('#t_country_name4')
    var usa_text4 = document.querySelector('#t_usa_hov4')

    usa_img4.style.backgroundImage = "url('https://www.eureporter.co/wp-content/uploads/2020/09/Ukraine.jpg')"
    country_name4.textContent = 'Ukraine '
    usa_text4.textContent = 'Ukraine – the ideal getaway for city walks, architecture and old town!'

    var usa_img5 = document.querySelector('#t_dis_usa5')
    var country_name5 = document.querySelector('#t_country_name5')
    var usa_text5 = document.querySelector('#t_usa_hov5')

    usa_img5.style.backgroundImage = "url('https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQXt7vDx29hiqrgcZJTqorc_CF4AggYUQYHdw&usqp=CAU')"
    country_name5.textContent = ' Czech Republic'
    usa_text5.textContent = 'Old Town, city walks and architecture are just a few reasons why travelers enjoy Czech Republic.'

}

function countryBtn7() {
    var usa_img1 = document.querySelector('#t_dis_usa1')
    var country_name1 = document.querySelector('#t_country_name1')
    var usa_text1 = document.querySelector('#t_usa_hov1')

    usa_img1.style.backgroundImage = "url('https://cdn.fodors.com/ee/files/slideshows/11675/switzerland-hero.jpg')"
    country_name1.textContent = 'Romania'
    usa_text1.textContent = 'Don’t miss out on Romania! Top destination for relaxation, old town and scenery.'

    var usa_img2 = document.querySelector('#t_dis_usa2')
    var country_name2 = document.querySelector('#t_country_name2')
    var usa_text2 = document.querySelector('#t_usa_hov2')

    usa_img2.style.backgroundImage = "url('https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcThz_We-P6GRZxExwgqUI_6CdcKekU-ycpvdA&usqp=CAU')"
    country_name2.textContent = 'Netherlands'
    usa_text2.textContent = 'Walking, city walks and cycling are just a few reasons why you’ll love Netherlands.'

    var usa_img3 = document.querySelector('#t_dis_usa3')
    var country_name3 = document.querySelector('#t_country_name3')
    var usa_text3 = document.querySelector('#t_usa_hov3')

    usa_img3.style.backgroundImage = "url('https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSvNcwE3WWEEUItNOmIbgFbRSx2Lq4b8mB0ow&usqp=CAU')"
    country_name3.textContent = 'Colombia'
    usa_text3.textContent = 'Colombia – the ideal getaway for relaxation, food and shopping!'

    var usa_img4 = document.querySelector('#t_dis_usa4')
    var country_name4 = document.querySelector('#t_country_name4')
    var usa_text4 = document.querySelector('#t_usa_hov4')

    usa_img4.style.backgroundImage = "url('https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTHDhN8k6muJrTLvc3jPgQugPcVGZ_i9mCorg&usqp=CAU')"
    country_name4.textContent = 'Hungary '
    usa_text4.textContent = 'Hungary– the ideal getaway for city walks, architecture and old town!'

    var usa_img5 = document.querySelector('#t_dis_usa5')
    var country_name5 = document.querySelector('#t_country_name5')
    var usa_text5 = document.querySelector('#t_usa_hov5')

    usa_img5.style.backgroundImage = "url('https://biggreenpurse.com/wp-content/uploads/2020/11/Turkey-2.jpg')"
    country_name5.textContent = 'Turkey'
    usa_text5.textContent = 'Old Town, city walks and architecture are just a few reasons why travelers enjoy Turkey.'

}

let subscribe = () => {
    let footer_top = document.getElementById("footer_top")
    footer_top.style.display = "none"

    let footer_lists = document.getElementById("footer_lists")
    footer_lists.style.marginTop = "-15%"
}
//display name using modal
document.getElementById("")
function addName() {

    document.querySelector(".bg-modal").style.display = "flex";

}
if (localStorage.getItem("name") == undefined && localStorage.getItem("Email") != undefined) {
    addName();
}

var rmReg = document.getElementById("removeRegister");
var rmSign = document.getElementById("removeSignIn")

document.querySelector(".close").addEventListener("click",
    function () {
        document.querySelector(".bg-modal").style.display = "none"
    })
document.querySelector("#dispName").addEventListener("click",
    function () {
        var nam = document.getElementById("fName").value//JSON.stringify()
        localStorage.setItem("name", nam);
        document.querySelector(".bg-modal").style.display = "none";

        document.getElementById("t_btn2").remove();
        document.getElementById("t_btn3").remove();
        rmSign.remove();
        rmReg.remove();

        document.getElementById("logName").textContent = ""
        var logName = document.createElement("div");
        logName.textContent = localStorage.getItem("name")
        logName.style.color = "white"
        document.getElementById("logName").appendChild(logName)


    })
if (localStorage.getItem("name") != undefined) {
    document.getElementById("t_btn2").remove();
    document.getElementById("t_btn3").remove();
    rmSign.remove();
    rmReg.remove();

    document.getElementById("logName").textContent = ""

    var img = document.createElement("img");
    img.src = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.bsn.eu%2Fwp-content%2Fuploads%2F2016%2F12%2Fuser-icon-image-placeholder-300-grey.jpg&f=1&nofb=1";
    img.style.width = "30px";
    img.style.borderRadius = "15px"
    document.getElementById("logName").appendChild(img)



    var logName = document.createElement("div");
    logName.textContent = localStorage.getItem("name")
    logName.style.color = "white";
    logName.style.fontWeight = "600";
    document.getElementById("logName").appendChild(logName)


}
img.addEventListener("click", () => {
    console.log("something")
    document.querySelector(".bg-modal2").style.display = "flex";
    document.querySelector("#manLogo").addEventListener("click", () => {
        img.src = document.querySelector("#manLogo").src;
        document.querySelector(".bg-modal2").style.display = "none";
    })
    document.querySelector("#womanLogo").addEventListener("click", () => {
        img.src = document.querySelector("#womanLogo").src;
        document.querySelector(".bg-modal2").style.display = "none";
    })

})
document.querySelector(".close2").addEventListener("click", () => {
    document.querySelector(".bg-modal2").style.display = "none";
})
    ;