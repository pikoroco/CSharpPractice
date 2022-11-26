### Legyen egy character abstract ősosztály.
* Életerő
* Név
* Életkor
* Tamad (Character ellenség)

### Legyen egy Varázsló származtatott osztály
* Az életerő property-t állítsuk be a constructorban 120-ra
* Overrideoljuk a Támad metódust :  az ellenség karakterén csökkentsük az életerőt random (1-10 között)
* Overrideoljuk a ToString() metódust, melyben kiiratjuk a képernyőre az életerejét és nevét
    
### Legyen egy Gladiator származtatott osztály
* Az életerő property-t állítsuk be a constructorban 140-re
* Overrideoljuk a Támad metódust :  az ellenség karakterén csökkentsük az életerőt random (2-6 között)
* Overrideoljuk a ToString() metódust, melyben kiiratjuk a képernyőre az életerejét és nevét

### Készítsünk egy Harctér osztályt 
* Legyen egy Character ElsoHarcos property-je
* Legyen egy Character MasodikHarcos property-je
* Legyen egy Eleteroket kiir metódus, melyben kiirjuk a terminálra a karakterek életerejét. A kiiratásnál a stringet próbáljuk meg a StringBuilder class segítségével létrehozni.
* Legyen egy Harc() void metódusa. A metódusban a harcos támadását szeretnénk szimulálni (meghívjuk az elsőharcos Támad metódusát, melybe beadjuk a MasodikHarcos objectet és fordítva). Egészen addig menjen a harc, amíg valamelyik harcos életereje el nem fogy. Minden körben írjuk ki hogy ki támad és hívjuk meg az EleteroketKiir metódust.