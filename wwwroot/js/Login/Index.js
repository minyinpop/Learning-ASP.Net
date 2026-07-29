const username = document.getElementById("username");
const password = document.getElementById("password");
const loginButton = document.getElementById("loginButton");

loginButton.addEventListener("click", onClickLoginButton);

async function onClickLoginButton()
{
    console.log("Login Button Clicked!")
}