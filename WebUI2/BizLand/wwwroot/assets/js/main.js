let underline=document.querySelector(".hover-underline-animation");
let dropdown=document.querySelector(".dropdown-toggle");
let menu=document.querySelector(".dropdown-menu");
let active=document.querySelector(".active")
dropdown.onmouseover=function () {
    menu.style.display="block";
    menu.style.zIndex="100";
}
dropdown.onmouseout=function () {
    menu.style.display="none";
};
let mainmenu=document.querySelector(".navbar-nav");
mainmenu.onclick=e=>  
  {
  if (e.target.tagName.toLowerCase() != 'a' ) return;
  e.preventDefault;
  let LI = e.target.parentElement;

  if (!LI.classList.contains('active'))
    {
        mainmenu.querySelector('.active').classList.remove('active');
    }
  LI.classList.add('active');
  }