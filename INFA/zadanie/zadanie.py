a = int()
b = int()
x = int(input("Podaj liczbe w systemie dwojkowych: "))

xxx = x

while x > 0:
    b += int(x % 10 * pow(2, a))
    a = int(a + 1)
    x = int(x / 10)
print(xxx, " W systemie dziesietnym to: ", b)
