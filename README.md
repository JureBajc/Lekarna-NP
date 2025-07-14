# 💊 Lekarna_NP – Simulacija Lekarniškega Sistema

## 📦 Opis

Lekarna_NP je objektno orientiran C# projekt, ki simulira osnovno delovanje lekarne. Podpira delo z zdravili, ustvarjanje računov, sledenje zalogi in delo z različnimi tipi zdravil (mazila, ampule, tablete, inhalatorji, raztopine).

---

## 🏗️ Struktura projekta

Lekarna_NP/
│
├── Program.cs // Glavna zagonna točka programa
├── PO_Artikel.cs // Osnovni razred za vse artikle
├── PO_Zdravilo.cs // Abstrakten razred za zdravila
├── SE_Mazilo.cs // Konkretni tipi zdravil (mazilo, tableta, ...)
├── SE_Tableta.cs
├── SE_Ampula.cs
├── SE_Raztopina.cs
├── SE_Inhilator.cs
│
├── PO_Racun.cs // Logika za izdajanje računov in izjeme
├── PO_RezerviranArtikel.cs // Rezervacija artikla za osebo
├── PO_Lekarna.cs // Glavna logika lekarne (dodajanje, rezervacije, zaloga)
│
├── Lekarna.cs // Lekarna z dogodki (obvestila strankam)
├── ILekarna.cs // Vmesnik lekarne
│
├── Inventar.cs // Branje/sortiranje podatkov iz CSV
├── Sestavine.cs // Sestavine zdravila
├── Oseba.cs // Oseba (stranka)
├── Zaposlen.cs // Zaposleni v lekarni
├── Stranka.cs // Stranka, ki se lahko naroči na obvestila
│
├── Podatki.csv // Vhodna datoteka s podatki o zdravilih
└── sortiranoV2.csv // Izhodna datoteka po sortiranju

yaml
Copy
Edit

---

## ✅ Glavne funkcionalnosti

- 📥 Branje zdravil iz `.csv` datoteke
- 🧪 Upravljanje s sestavinami zdravil
- 🧾 Rezervacija in izdaja računov
- 💰 Izračun cene na podlagi recepta in zavarovanja
- 📦 Upravljanje zaloge
- 🔔 Obveščanje strank prek dogodkov
- 🔎 Iskanje zdravil po ceni, imenu ali državi
- 🧹 Odstranjevanje artiklov z iztečenim rokom trajanja

---

## 🚀 Zagon

1. Odpri projekt v Visual Studio.
2. Prepričaj se, da datoteka `Podatki.csv` obstaja na predvideni poti.
3. Poženi `Program.cs` z `Ctrl + F5`.

> Če uporabljaš lastno pot do `.csv`, posodobi spremenljivko `podatki` v `Program.cs`.

---

## 🛠️ Tehnične podrobnosti

- **.NET Framework:** .NET 6 ali višje
- **Paradigma:** Objektno usmerjeno programiranje
- **Vhodni podatki:** CSV datoteka (semi-colon ločena)
- **Izhod:** Sortirana CSV in konzolni izpis

---

## 🧪 Testiranje

Program testira funkcionalnosti v `Main` metodi, vključno z:
- dodajanjem artiklov,
- ustvarjanjem računov,
- rezervacijami in sprostitvami,
- filtriranjem po ceni, imenu in državi.

---
---

## 📧 Avtor

**Jure Bajc**  
Fakulteta za elektrotehniko, računalništvo in informatiko  
Univerza v Mariboru
