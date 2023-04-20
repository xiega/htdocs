<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style2.css">
    <title>Warzywniak</title>
</head>

<body>
    <header>
        <div id="lewy">
            <h1>Internetowy sklep e eko-warzywami</h1>
        </div>
        <div id="prawy">
            <ol>
                <li>warzywa</li>
                <li>owoce</li>
                <li><a href="https://terapiasokami.pl/" target="_blank">soki</a></li>
            </ol>
        </div>
    </header>
    <main>
        <?php
        $conn = mysqli_connect('localhost', 'root', '', 'dane2');
        $qr1 = "SELECT nazwa, ilosc, opis, cena, zdjecie FROM produkty WHERE Rodzaje_id IN (1,2);";
        $res1 = mysqli_query($conn, $qr1);
        while ($row = mysqli_fetch_array($res1)) {
            echo "<div class='box'> <img src='" . $row[4] . "' alt='warzywniak'> <h5>" . $row[0] . "</h5> <p>opis: " . $row[2] . "</p> <p>na stanie:" . $row[1] . "</p> <h2>" . $row[3] . " zł</h2> </div>";
        }
        mysqli_close($conn);
        ?>
    </main>
    <footer>
        <form>
            <input name="nazwa" type="text" placeholder="Nazwa:">
            <input name="cena" type="text" placeholder="Cena:">
            <button type="submit" name="button">Dodaj produkt</button>
        </form>
        <p>Stronę wykonał: 11111111111</p>
    </footer>
</body>

</html>