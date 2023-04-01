<!DOCTYPE html>
<html>
<head>
	<title>Formularz logowania</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <main>
        <header>
            <h2>Formularz logowania</h2>
        </header>
            <section>
                <form method="post" action="index.php">
                    <label for="username">Nazwa użytkownika:</label>
                    <input type="text" id="username" name="username" required>

                    <label for="password">Hasło:</label>
                    <input type="password" id="password" name="password" required>

                    <input type="submit" value="Zaloguj">
                </form>
            </section>
        <center><hr></center>
        <article>
            <?php
            if(isset($_POST['username'])) {
                error_reporting(0);

                $conn = mysqli_connect("localhost", "root", "", "spr");
                $username = $_POST['username'];
                $password = $_POST['password'];
                $counter = 0;

                $query = "SELECT * FROM konta WHERE login='$username' AND haslo='$password'";
                $result = mysqli_query($conn, $query);
                if ($result->num_rows > 0) {
				$sql_animals = "SELECT * FROM animals";
				$result_animals = $conn->query($sql_animals);

				if ($result_animals->num_rows > 0) {
                    while ($row_animals = $result_animals->fetch_assoc()) {
                    $counter++;
                    echo    "<div class='baza'>
                                <div class='img'><img src='pies.jpg'></div>
                                <div class='tytul'><h3>{$row_animals['nazwa']}</h3></div>
                                <div class='opis'>
                                    <h4>Opis:</h4>
                                    <p>{$row_animals['opis']}</p>
                                </div>
                            </div>

                            ";
                }
                } 
                else {
                    echo "<p>Brak danych.</p>";
                }
                }
                else {
                    echo "<div class='error'>Nieprawidłowa nazwa użytkownika lub hasło.</div>";
                }
                mysqli_close($conn);
            }
            ?>
        </article>
        <footer>
            <h2>PESEL: 00000000000</h2>
        </footer>   
    </main>
</body>
<script src="skrypt.js"></script>
</html>
