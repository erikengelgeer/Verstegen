﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
!function (a) {
    "use strict";
    a(".menu-toggle").click(function (e) {
        e.preventDefault(), a("#sidebar-wrapper").toggleClass("active"), a(".menu-toggle > .fa-bars, .menu-toggle > .fa-times").toggleClass("fa-bars fa-times"), a(this).toggleClass("active");
    }), a('a.js-scroll-trigger[href*="#"]:not([href="#"])').click(function () {
        if (location.pathname.replace(/^\//, "") == this.pathname.replace(/^\//, "") && location.hostname == this.hostname) {
            var e = a(this.hash);
            if ((e = e.length ? e : a("[name=" + this.hash.slice(1) + "]")).length) return a("html, body").animate({
                scrollTop: e.offset().top
            }, 1e3, "easeInOutExpo"), !1;
        }
    }), a("#sidebar-wrapper .js-scroll-trigger").click(function () {
        a("#sidebar-wrapper").removeClass("active"), a(".menu-toggle").removeClass("active"), a(".menu-toggle > .fa-bars, .menu-toggle > .fa-times").toggleClass("fa-bars fa-times");
    }), a(document).scroll(function () {
        100 < a(this).scrollTop() ? a(".scroll-to-top").fadeIn() : a(".scroll-to-top").fadeOut();
    })
}(jQuery);