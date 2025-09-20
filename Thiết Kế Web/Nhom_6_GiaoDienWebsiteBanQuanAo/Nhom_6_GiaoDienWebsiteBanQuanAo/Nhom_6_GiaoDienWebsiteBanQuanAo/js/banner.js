const slides = document.querySelectorAll(".slide");
const dots = document.querySelectorAll(".dot");
let currentSlide = 0;

function showSlide(index) {
  slides.forEach((slide, i) => {
    slide.classList.remove("active");
    dots[i].classList.remove("active");
    if (i === index) {
      slide.classList.add("active");
      dots[i].classList.add("active");
    }
  });
  currentSlide = index;
}

document.querySelector(".prev").addEventListener("click", () => {
  let next = currentSlide - 1;
  if (next < 0) next = slides.length - 1;
  showSlide(next);
});

document.querySelector(".next").addEventListener("click", () => {
  let next = currentSlide + 1;
  if (next >= slides.length) next = 0;
  showSlide(next);
});

dots.forEach((dot, i) => {
  dot.addEventListener("click", () => showSlide(i));
});

// Auto slide every 5s
setInterval(() => {
  let next = (currentSlide + 1) % slides.length;
  showSlide(next);
}, 5000);
