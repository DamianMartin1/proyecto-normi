@import url("https://fonts.googleapis.com/css2?family=Hind+Madurai:wght@400;700&family=Jockey+One&display=swap");
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

body {
  line-height: normal;
}

h1, h2, h3, h4, h5, h6, p {
  margin: 0;
}

ul {
  padding-left: 0;
  margin-bottom: 0;
}

header {
  background: #0E6AF4;
}
header .navbar-brand {
  transition: transform 0.4s cubic-bezier(0.37, 0, 0.63, 1);
}
header .navbar-brand:hover {
  transform: scale(1.1);
}

.nav-item {
  transition: transform 0.4s cubic-bezier(0.37, 0, 0.63, 1);
}
.nav-item:hover {
  transform: scale(1.1);
}

.main-index {
  width: 100%;
  padding-bottom: 1.25rem;
  background-color: #1D1C1C;
}
.main-index .div-h1 {
  display: flex;
  justify-content: center;
  padding-top: 3.75rem;
  text-align: center;
}
.main-index .div-h1 h1 {
  padding-top: 0.9375rem;
  background-color: white;
  font-family: "Jockey One", sans-serif;
  font-weight: 700;
  width: 50%;
  height: 5rem;
  letter-spacing: 0.1875rem;
}
.main-index section {
  display: grid;
  width: 100%;
  justify-content: center;
  grid-template-columns: repeat(2, 28.125rem);
  grid-template-rows: 25rem 25rem;
  grid-template-areas: "sand papa" "tort lomi";
  gap: 1.875rem;
  padding-top: 4.375rem;
}
.main-index section .card-1 {
  grid-area: sand;
  width: 100%;
  background-color: #FF0303;
}
.main-index section .card-1 img {
  width: 25rem;
  height: 16.25rem;
  margin-top: 1rem;
  margin-left: 1.5625rem;
}
.main-index section .card-1 h2 {
  color: white;
  text-align: center;
  font-family: "Hind Madurai", sans-serif;
  font-weight: bold;
  font-size: 2.8125rem;
}
.main-index section .card-1 div {
  width: 6.25rem;
  height: 2.1875rem;
  background-color: white;
  border-radius: 0.1875rem;
  text-align: center;
  margin-left: 10.625rem;
  margin-top: 1.25rem;
}
.main-index section .card-1 div a {
  font-family: "Hind Madurai", sans-serif;
  font-weight: 600;
  font-size: 1.375rem;
  text-decoration: none;
  color: black;
}
.main-index section .card-2 {
  grid-area: papa;
  width: 100%;
  background-color: #FF0303;
}
.main-index section .card-2 img {
  width: 25rem;
  height: 16.25rem;
  margin-top: 1rem;
  margin-left: 1.5625rem;
}
.main-index section .card-2 h2 {
  color: white;
  text-align: center;
  font-family: "Hind Madurai", sans-serif;
  font-weight: bold;
  font-size: 2.8125rem;
}
.main-index section .card-2 div {
  width: 6.25rem;
  height: 2.1875rem;
  background-color: white;
  border-radius: 0.1875rem;
  text-align: center;
  margin-left: 10.625rem;
  margin-top: 1.25rem;
}
.main-index section .card-2 div a {
  font-family: "Hind Madurai", sans-serif;
  font-weight: 600;
  font-size: 1.375rem;
  text-decoration: none;
  color: black;
}
.main-index section .card-3 {
  grid-area: tort;
  width: 100%;
  background-color: #FF0303;
}
.main-index section .card-3 img {
  width: 25rem;
  height: 16.25rem;
  margin-top: 1rem;
  margin-left: 1.5625rem;
}
.main-index section .card-3 h2 {
  color: white;
  text-align: center;
  font-family: "Hind Madurai", sans-serif;
  font-weight: bold;
  font-size: 2.8125rem;
}
.main-index section .card-3 div {
  width: 6.25rem;
  height: 2.1875rem;
  background-color: white;
  border-radius: 0.1875rem;
  text-align: center;
  margin-left: 10.625rem;
  margin-top: 1.25rem;
}
.main-index section .card-3 div a {
  font-family: "Hind Madurai", sans-serif;
  font-weight: 600;
  font-size: 1.375rem;
  text-decoration: none;
  color: black;
}
.main-index section .card-4 {
  grid-area: lomi;
  width: 100%;
  background-color: #FF0303;
}
.main-index section .card-4 img {
  width: 25rem;
  height: 16.25rem;
  margin-top: 1rem;
  margin-left: 1.5625rem;
}
.main-index section .card-4 h2 {
  color: white;
  text-align: center;
  font-family: "Hind Madurai", sans-serif;
  font-weight: bold;
  font-size: 2.8125rem;
}
.main-index section .card-4 div {
  width: 6.25rem;
  height: 2.1875rem;
  background-color: white;
  border-radius: 0.1875rem;
  text-align: center;
  margin-left: 10.625rem;
  margin-top: 1.25rem;
}
.main-index section .card-4 div a {
  font-family: "Hind Madurai", sans-serif;
  font-weight: 600;
  font-size: 1.375rem;
  text-decoration: none;
  color: black;
}

.main-sand {
  width: 100%;
  background-color: #1D1C1C;
}
.main-sand section {
  display: flex;
  flex-direction: column;
  align-items: center;
  padding-top: 3.125rem;
  gap: 3.125rem;
}
.main-sand section .div-1 {
  border-radius: 0.375rem;
  background-color: white;
  width: 60%;
  height: 10.9375rem;
  display: flex;
  flex-direction: row;
}
.main-sand section .div-1 img {
  width: 36%;
  height: 8.75rem;
  align-self: center;
  margin-left: 1.1875rem;
  border-radius: 5px;
}
.main-sand section .div-1 div {
  width: 100%;
  text-align: center;
}
.main-sand section .div-1 div h1 {
  font-family: "Hind Madurai", sans-serif;
  font-weight: 500;
  font-size: 2.25rem;
  padding-top: 0.3125rem;
}
.main-sand section .div-1 div p {
  padding-top: 0.4375rem;
  font-size: 1.5625rem;
  font-weight: bold;
}
.main-sand section .div-1 div h3 {
  padding-top: 1rem;
}
.main-sand section .div-2 {
  border-radius: 0.375rem;
  background-color: white;
  width: 60%;
  height: 10.9375rem;
  display: flex;
  flex-direction: row;
}
.main-sand section .div-2 img {
  width: 26.4%;
  height: 8.75rem;
  align-self: center;
  margin-left: 1.1875rem;
  border-radius: 5px;
}
.main-sand section .div-2 div {
  width: 100%;
  text-align: center;
}
.main-sand section .div-2 div h2 {
  font-family: "Hind Madurai", sans-serif;
  font-weight: 500;
  font-size: 1.875rem;
  padding-top: 0.3125rem;
}
.main-sand section .div-2 div p {
  padding-top: 0.4375rem;
  font-size: 1.5625rem;
  font-weight: bold;
}
.main-sand section .div-2 div h3 {
  padding-top: 1rem;
}
.main-sand section .div-3 {
  border-radius: 0.375rem;
  background-color: white;
  width: 60%;
  height: 10.9375rem;
  display: flex;
  flex-direction: row;
}
.main-sand section .div-3 img {
  width: 26.4%;
  height: 8.75rem;
  align-self: center;
  margin-left: 1.1875rem;
  border-radius: 5px;
}
.main-sand section .div-3 div {
  width: 100%;
  text-align: center;
}
.main-sand section .div-3 div h2 {
  font-family: "Hind Madurai", sans-serif;
  font-weight: 500;
  font-size: 1.875rem;
  padding-top: 0.3125rem;
}
.main-sand section .div-3 div p {
  padding-top: 0.4375rem;
  font-size: 1.5625rem;
  font-weight: bold;
}
.main-sand section .div-3 div h3 {
  padding-top: 1rem;
}
.main-sand section .div-4 {
  border-radius: 0.375rem;
  background-color: white;
  width: 60%;
  height: 10.9375rem;
  display: flex;
  flex-direction: row;
  margin-bottom: 3.125rem;
}
.main-sand section .div-4 img {
  width: 38%;
  height: 8.75rem;
  align-self: center;
  margin-left: 1.1875rem;
  border-radius: 5px;
}
.main-sand section .div-4 div {
  width: 100%;
  text-align: center;
}
.main-sand section .div-4 div h2 {
  font-family: "Hind Madurai", sans-serif;
  font-weight: 500;
  font-size: 1.875rem;
  padding-top: 0.3125rem;
}
.main-sand section .div-4 div p {
  padding-top: 0.4375rem;
  font-size: 1.5625rem;
  font-weight: bold;
}
.main-sand section .div-4 div h3 {
  padding-top: 1rem;
}

.main-papas {
  background-color: #1D1C1C;
}
.main-papas section {
  display: flex;
  flex-direction: column;
  align-items: center;
  padding-top: 3.125rem;
  gap: 3.125rem;
}
.main-papas section .div-1 {
  border-radius: 0.375rem;
  background-color: white;
  width: 60%;
  height: 10.9375rem;
  display: flex;
  flex-direction: row;
}
.main-papas section .div-1 img {
  width: 40%;
  height: 8.75rem;
  align-self: center;
  margin-left: 1.1875rem;
  border-radius: 0.3125rem;
}
.main-papas section .div-1 div {
  width: 100%;
  text-align: center;
}
.main-papas section .div-1 div h1 {
  font-family: "Hind Madurai", sans-serif;
  font-weight: 500;
  font-size: 2.5rem;
  padding-top: 0.3125rem;
}
.main-papas section .div-1 div p {
  padding-top: 0.4375rem;
  font-size: 1.5625rem;
  font-weight: bold;
}
.main-papas section .div-1 div h3 {
  padding-top: 1rem;
}
.main-papas section .div-2 {
  border-radius: 0.375rem;
  background-color: white;
  width: 60%;
  height: 10.9375rem;
  display: flex;
  flex-direction: row;
}
.main-papas section .div-2 img {
  width: 40%;
  height: 8.75rem;
  align-self: center;
  margin-left: 1.1875rem;
  border-radius: 0.3125rem;
}
.main-papas section .div-2 div {
  width: 100%;
  text-align: center;
}
.main-papas section .div-2 div h2 {
  font-family: "Hind Madurai", sans-serif;
  font-weight: 500;
  font-size: 1.875rem;
  padding-top: 0.3125rem;
}
.main-papas section .div-2 div p {
  padding-top: 0.4375rem;
  font-size: 1.5625rem;
  font-weight: bold;
}
.main-papas section .div-2 div h3 {
  padding-top: 1rem;
}
.main-papas section .div-3 {
  border-radius: 0.375rem;
  background-color: white;
  width: 60%;
  height: 10.9375rem;
  display: flex;
  flex-direction: row;
  margin-bottom: 3.125rem;
}
.main-papas section .div-3 img {
  width: 40%;
  height: 8.75rem;
  align-self: center;
  margin-left: 1.1875rem;
  border-radius: 0.3125rem;
}
.main-papas section .div-3 div {
  width: 100%;
  text-align: center;
}
.main-papas section .div-3 div h2 {
  font-family: "Hind Madurai", sans-serif;
  font-weight: 500;
  font-size: 1.875rem;
  padding-top: 0.3125rem;
}
.main-papas section .div-3 div p {
  padding-top: 2.0625rem;
  font-size: 1.5625rem;
  font-weight: bold;
}
.main-papas section .div-3 div h3 {
  padding-top: 1.5625rem;
}

.main-tortillas {
  background-color: #1D1C1C;
}
.main-tortillas section {
  display: flex;
  flex-direction: column;
  align-items: center;
  padding-top: 3.125rem;
  gap: 3.125rem;
}
.main-tortillas section .div-1 {
  border-radius: 0.375rem;
  background-color: white;
  width: 60%;
  height: 10.9375rem;
  display: flex;
  flex-direction: row;
}
.main-tortillas section .div-1 img {
  width: 40%;
  height: 8.75rem;
  align-self: center;
  margin-left: 1.1875rem;
  border-radius: 0.3125rem;
}
.main-tortillas section .div-1 div {
  width: 100%;
  text-align: center;
}
.main-tortillas section .div-1 div h1 {
  font-family: "Hind Madurai", sans-serif;
  font-weight: 500;
  font-size: 2.5rem;
  padding-top: 0.3125rem;
}
.main-tortillas section .div-1 div p {
  padding-top: 1.125rem;
  font-size: 1.5625rem;
  font-weight: bold;
}
.main-tortillas section .div-1 div h3 {
  padding-top: 1.875rem;
}
.main-tortillas section .div-2 {
  border-radius: 0.375rem;
  background-color: white;
  width: 60%;
  height: 10.9375rem;
  display: flex;
  flex-direction: row;
}
.main-tortillas section .div-2 img {
  width: 40%;
  height: 8.75rem;
  align-self: center;
  margin-left: 1.1875rem;
  border-radius: 0.3125rem;
}
.main-tortillas section .div-2 div {
  width: 100%;
  text-align: center;
}
.main-tortillas section .div-2 div h2 {
  font-family: "Hind Madurai", sans-serif;
  font-weight: 500;
  font-size: 1.875rem;
  padding-top: 0.3125rem;
}
.main-tortillas section .div-2 div p {
  padding-top: 1.875rem;
  font-size: 1.5625rem;
  font-weight: bold;
}
.main-tortillas section .div-2 div h3 {
  padding-top: 1.5625rem;
}
.main-tortillas section .div-3 {
  border-radius: 0.375rem;
  background-color: white;
  width: 60%;
  height: 10.9375rem;
  display: flex;
  flex-direction: row;
  margin-bottom: 3.125rem;
}
.main-tortillas section .div-3 img {
  width: 28%;
  height: 8.75rem;
  align-self: center;
  margin-left: 1.1875rem;
  border-radius: 0.3125rem;
}
.main-tortillas section .div-3 div {
  width: 100%;
  text-align: center;
}
.main-tortillas section .div-3 div h2 {
  font-family: "Hind Madurai", sans-serif;
  font-weight: 500;
  font-size: 2.1875rem;
  padding-top: 0.3125rem;
}
.main-tortillas section .div-3 div p {
  padding-top: 1.0625rem;
  font-size: 1.5625rem;
  font-weight: bold;
}
.main-tortillas section .div-3 div h3 {
  padding-top: 1.5625rem;
}

.main-lomito {
  background-color: #1D1C1C;
}
.main-lomito section {
  display: flex;
  flex-direction: column;
  align-items: center;
  padding-top: 3.125rem;
  gap: 3.125rem;
}
.main-lomito section .div-1 {
  border-radius: 0.375rem;
  background-color: white;
  width: 60%;
  height: 10.9375rem;
  display: flex;
  flex-direction: row;
}
.main-lomito section .div-1 img {
  width: 38%;
  height: 8.75rem;
  align-self: center;
  margin-left: 1.1875rem;
  border-radius: 5px;
}
.main-lomito section .div-1 div {
  width: 100%;
  text-align: center;
}
.main-lomito section .div-1 div h1 {
  font-family: "Hind Madurai", sans-serif;
  font-weight: 500;
  font-size: 2.25rem;
  padding-top: 0.3125rem;
}
.main-lomito section .div-1 div p {
  padding-top: 0.4375rem;
  font-size: 1.5625rem;
  font-weight: bold;
}
.main-lomito section .div-1 div h3 {
  padding-top: 1rem;
}
.main-lomito section .div-2 {
  border-radius: 0.375rem;
  background-color: white;
  width: 60%;
  height: 10.9375rem;
  display: flex;
  flex-direction: row;
}
.main-lomito section .div-2 img {
  width: 38%;
  height: 8.75rem;
  align-self: center;
  margin-left: 1.1875rem;
  border-radius: 5px;
}
.main-lomito section .div-2 div {
  width: 100%;
  text-align: center;
}
.main-lomito section .div-2 div h2 {
  font-family: "Hind Madurai", sans-serif;
  font-weight: 500;
  font-size: 1.875rem;
  padding-top: 0.3125rem;
}
.main-lomito section .div-2 div p {
  padding-top: 0.4375rem;
  font-size: 1.5625rem;
  font-weight: bold;
}
.main-lomito section .div-2 div h3 {
  padding-top: 1rem;
}
.main-lomito section .div-3 {
  border-radius: 0.375rem;
  background-color: white;
  width: 60%;
  height: 10.9375rem;
  display: flex;
  flex-direction: row;
}
.main-lomito section .div-3 img {
  width: 38%;
  height: 8.75rem;
  align-self: center;
  margin-left: 1.1875rem;
  border-radius: 5px;
}
.main-lomito section .div-3 div {
  width: 100%;
  text-align: center;
}
.main-lomito section .div-3 div h2 {
  font-family: "Hind Madurai", sans-serif;
  font-weight: 500;
  font-size: 1.875rem;
  padding-top: 0.3125rem;
}
.main-lomito section .div-3 div p {
  padding-top: 0.4375rem;
  font-size: 1.5625rem;
  font-weight: bold;
}
.main-lomito section .div-3 div h3 {
  padding-top: 1rem;
}
.main-lomito section .div-4 {
  border-radius: 0.375rem;
  background-color: white;
  width: 60%;
  height: 10.9375rem;
  display: flex;
  flex-direction: row;
  margin-bottom: 3.125rem;
}
.main-lomito section .div-4 img {
  width: 27%;
  height: 8.75rem;
  align-self: center;
  margin-left: 1.1875rem;
  border-radius: 5px;
}
.main-lomito section .div-4 div {
  width: 100%;
  text-align: center;
}
.main-lomito section .div-4 div h2 {
  font-family: "Hind Madurai", sans-serif;
  font-weight: 500;
  font-size: 1.875rem;
  padding-top: 0.3125rem;
}
.main-lomito section .div-4 div p {
  padding-top: 0.4375rem;
  font-size: 1.5625rem;
  font-weight: bold;
}
.main-lomito section .div-4 div h3 {
  padding-top: 1rem;
}

@media (max-width: 1024px) {
  .main-index .div-h1 h1 {
    width: 70%;
  }
  .main-index section {
    grid-template-columns: repeat(2, 21.875rem);
  }
  .main-index section .card-1 img {
    width: 18.75rem;
    height: 14.375rem;
  }
  .main-index section .card-1 h2 {
    padding-top: 1rem;
  }
  .main-index section .card-1 div {
    margin-left: 7.8125rem;
  }
  .main-index section .card-2 img {
    width: 18.75rem;
    height: 14.375rem;
  }
  .main-index section .card-2 h2 {
    padding-top: 1rem;
  }
  .main-index section .card-2 div {
    margin-left: 7.8125rem;
  }
  .main-index section .card-3 img {
    width: 18.75rem;
    height: 14.375rem;
  }
  .main-index section .card-3 h2 {
    padding-top: 1rem;
  }
  .main-index section .card-3 div {
    margin-left: 7.8125rem;
  }
  .main-index section .card-4 img {
    width: 18.75rem;
    height: 14.375rem;
  }
  .main-index section .card-4 h2 {
    padding-top: 1rem;
  }
  .main-index section .card-4 div {
    margin-left: 7.8125rem;
  }
}
@media (max-width: 768px) {
  .main-index .div-h1 h1 {
    width: 83%;
  }
  .main-index section {
    grid-template-columns: repeat(2, 18.75rem);
  }
  .main-index section .card-1 {
    height: 90%;
  }
  .main-index section .card-1 img {
    width: 15.625rem;
    height: 12.5rem;
  }
  .main-index section .card-1 h2 {
    padding-top: 1rem;
  }
  .main-index section .card-1 div {
    margin-left: 6.25rem;
  }
  .main-index section .card-2 {
    height: 90%;
  }
  .main-index section .card-2 img {
    width: 15.625rem;
    height: 12.5rem;
  }
  .main-index section .card-2 h2 {
    padding-top: 1rem;
  }
  .main-index section .card-2 div {
    margin-left: 6.25rem;
  }
  .main-index section .card-3 {
    height: 90%;
  }
  .main-index section .card-3 img {
    width: 15.625rem;
    height: 12.5rem;
  }
  .main-index section .card-3 h2 {
    padding-top: 1rem;
  }
  .main-index section .card-3 div {
    margin-left: 6.25rem;
  }
  .main-index section .card-4 {
    height: 90%;
  }
  .main-index section .card-4 img {
    width: 15.625rem;
    height: 12.5rem;
  }
  .main-index section .card-4 h2 {
    padding-top: 1rem;
  }
  .main-index section .card-4 div {
    margin-left: 6.25rem;
  }
}
@media (max-width: 650px) {
  .main-index section {
    grid-template-columns: repeat(1, 21.875rem);
    grid-template-rows: repeat(4, 25rem);
    grid-template-areas: "sand" "papa" "tort" "lomi";
    gap: 0.625rem;
  }
  .main-index section .card-1 {
    height: 90%;
  }
  .main-index section .card-1 img {
    width: 15.625rem;
    height: 12.5rem;
  }
  .main-index section .card-1 h2 {
    padding-top: 1rem;
  }
  .main-index section .card-1 div {
    margin-left: 6.25rem;
  }
  .main-index section .card-2 {
    height: 90%;
  }
  .main-index section .card-2 img {
    width: 15.625rem;
    height: 12.5rem;
  }
  .main-index section .card-2 h2 {
    padding-top: 1rem;
  }
  .main-index section .card-2 div {
    margin-left: 6.25rem;
  }
  .main-index section .card-3 {
    height: 90%;
  }
  .main-index section .card-3 img {
    width: 15.625rem;
    height: 12.5rem;
  }
  .main-index section .card-3 h2 {
    padding-top: 1rem;
  }
  .main-index section .card-3 div {
    margin-left: 6.25rem;
  }
  .main-index section .card-4 {
    height: 90%;
  }
  .main-index section .card-4 img {
    width: 15.625rem;
    height: 12.5rem;
  }
  .main-index section .card-4 h2 {
    padding-top: 1rem;
  }
  .main-index section .card-4 div {
    margin-left: 6.25rem;
  }
}
@media (max-width: 480px) {
  .main-index .div-h1 h1 {
    padding-top: 0.5rem;
  }
}
@media (max-width: 379px) {
  .main-index section {
    grid-template-columns: repeat(1, 300px);
  }
  .main-index section .card-1 {
    height: 90%;
  }
  .main-index section .card-1 img {
    width: 15.625rem;
    height: 12.5rem;
  }
  .main-index section .card-1 h2 {
    padding-top: 1rem;
  }
  .main-index section .card-1 div {
    margin-left: 6.25rem;
  }
  .main-index section .card-2 {
    height: 90%;
  }
  .main-index section .card-2 img {
    width: 15.625rem;
    height: 12.5rem;
  }
  .main-index section .card-2 h2 {
    padding-top: 1rem;
  }
  .main-index section .card-2 div {
    margin-left: 6.25rem;
  }
  .main-index section .card-3 {
    height: 90%;
  }
  .main-index section .card-3 img {
    width: 15.625rem;
    height: 12.5rem;
  }
  .main-index section .card-3 h2 {
    padding-top: 1rem;
  }
  .main-index section .card-3 div {
    margin-left: 6.25rem;
  }
  .main-index section .card-4 {
    height: 90%;
  }
  .main-index section .card-4 img {
    width: 15.625rem;
    height: 12.5rem;
  }
  .main-index section .card-4 h2 {
    padding-top: 1rem;
  }
  .main-index section .card-4 div {
    margin-left: 6.25rem;
  }
}

/*# sourceMappingURL=style.cs.map */
