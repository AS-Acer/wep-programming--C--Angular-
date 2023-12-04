dolarDun = 7.35
dolarBugun = 7.45

#veriler veritabanından geliyor olacak

if dolarDun > dolarBugun :
    print("Azalış oku")

elif dolarDun == dolarBugun :
    print("Değişmedi oku")

else : print("Artış oku")