//header
let header = document.querySelector('header');
let menu = document.querySelector('#menu-icon');
let navbar = document.querySelector('.navbar');



window.addEventListener('scroll', () => {
    header.classList.toggle('shadow', window.scrollY > 0)
})

menu.onclick = () => {
    menu.classList.toggle('bx-x');
    navbar.classList.toggle('active');
}

window.onscroll = () => {
    menu.classList.remove('bx-x');
    navbar.classList.remove('active');
}

//hero swiper
var swiper = new Swiper(".home", {
    spaceBetween: 30,
    centeredSlides: true,
    autoplay: {
        delay: 3000,
        disableOnInteraction: false,
    },
    pagination: {
        el: ".swiper-pagination",
        clickable: true,
    },

});

//swiper

var swiper = new Swiper(".coming-container", {
    spaceBetween: 30,
    loop: true,
    autoplay: {
        delay: 3000,
        disableOnInteraction: false,
    },
    centeredSlides: true,
    breakpoints: {
        0: {
            sledesPerView: 2,
        },
        568: {
            slidesPerView: 3,
        },
        768: {
            slidesPerView: 4,
        },
        968: {
            slidesPerView: 5,
        }
    },
});

//show video

let playButton = document.querySelector('.play-movie');
let video = document.querySelector('.video-container');
let closebtn = document.querySelector('.close-video');

playButton.onclick = () => {
    video.classList.add("show-video");
};

closebtn.onclick = () => {
    video.classList.remove("show-video");

}
function newComment() {
    const date = new Date();
    var months = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];
    var stringdata = "";
    var fulldate = stringdata.concat(date.getDate(), " ", months[date.getMonth()], " ", date.getFullYear(), "  ", date.getHours(), ":", date.getMinutes());
    var fullname = document.getElementById("full-name").value;
    var comment = document.getElementById("comment").value;
    console.log(comment)
    if (fullname == "" || comment == "") {
        alert("Fill the blanks");
    }
    else {
        var user_comment_box = document.createElement("div");
        var user_img_box = document.createElement("div");
        var user_img_com_bx_bxs_face_mask = document.createElement("i");
        var user_comment = document.createElement("div");
        var name_header = document.createElement("h4");
        var comment_of_user = document.createElement("p");
        var comm_date = document.createElement("div");
        var date_show = document.createElement("h6");
        var commentsection = document.getElementById("newcommentprepend");

        name_header.innerHTML = fullname;
        comment_of_user.innerHTML = comment;
        date_show.innerHTML = fulldate;

        user_comment_box.classList.add("user-comment-box");
        user_img_box.classList.add("user-img-box");
        user_img_com_bx_bxs_face_mask.classList.add("user-img-com");
        user_img_com_bx_bxs_face_mask.classList.add("bx");
        user_img_com_bx_bxs_face_mask.classList.add("bxs-face-mask");
        user_comment.classList.add("user-comment");
        comm_date.classList.add("comm-date");

        commentsection.prepend(user_comment_box);
        user_comment_box.append(user_img_box);
        user_img_box.append(user_img_com_bx_bxs_face_mask);
        user_comment_box.append(user_comment);
        user_comment.append(comm_date);
        comm_date.append(name_header);
        comm_date.append(date_show);
        user_comment.append(comment_of_user);



    }

}
function handleChange(checkbox) {
    var category = checkbox.value;
    var elems = document.getElementsByClassName(category);
    if (checkbox.checked == true) {
        for (let i = 0; i < elems.length; i++) {
            elems[i].classList.replace("deactive", "active");
        }
    }
    else {
        for (let i = 0; i < elems.length; i++) {
            var classes = elems[i].classList;
            var flag = true;
            for (let j = 1; j < classes.length - 1; j++) {
                var classname = document.getElementById(classes[j]);
                if (classname == null) {
                    continue;
                }
                else {
                    if ((classname.checked == true) && (classname.value != category)) {
                        flag = false;
                        break;
                    }
                }
            }
            if (flag) {
                elems[i].classList.replace("active", "deactive");
            }
        }
    }
}
// comment





//https://squoosh.app/editor
//https://boxicons.com/
//https://wall.alphacoders.com/by_sub_category.php?id=317484&name=Doctor+Strange+in+the+Multiverse+of+Madness+Wallpapers