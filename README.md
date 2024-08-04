Bu projede Dapper ORM kullanarak dashboard ekranı ve verilerin listelendiği filitrelenebildiği bir proje geliştirdim.<br>
Projede veri seti olarak Ömer Çolakoğlu hocamızın kaggle üzerinde ücretsiz olarak yayınladığı içerisinde 4 milyon fake araba plakalarının bulunduğu "4 Million Turkish Car Plate Dataset with Fake Data" veri setini kullandım.

  <h1> ☆ Dapper nedir ?  ☆ </h1>

📌Dapper, .NET dünyası ORM Aracıdır. Veritabanı işlemleri için herhangi bir .NET projesine eklenebilen bir NuGet kitaplığıdır. ORM (Object Relational Mapping), Nesne İlişkisel Eşleme anlamına gelir.

☆ Neden Dapper Kullanmalıyız? ☆  
<ul>
  <li>Oldukça hafif ve yüksek performanslıdır.</li>
  <li>Veritabanı erişim kodunu büyük ölçüde azaltır.</li>
  <li>Herhangi bir veritabanı ile çalışabilir. SQL Server, Oracle, SQLite, MySQL, PoestgreSQL vb.</li>
</ul>

☆ Dapper’ı Ne Zaman Kullanmalısınız? ☆ <br> <br>
📌 Dapper’ı kullanıp kullanmamaya karar verirken, birincil neden olarak performans akılda tutulmalıdır <br>
📌 Dapper, verilerin sık sık değiştiği ve istendiği senaryolarda iyi bir seçimdir. 

<h1>Dapper Nasıl Kullanılır?</h1>

![image](https://github.com/user-attachments/assets/30f70228-41a3-4774-9c99-04ef38abd5b2)

📌 Öncelikle geliştirme yapacağımız proje içerisine Dapper kütüphanesini dahil etmeliyiz.

![image](https://github.com/user-attachments/assets/3a75df47-716f-49e2-a434-8de58ad67dcb)

📌 2. adım olarak "appsettings.json" dosyasında kullanıcağımız veritabanının bağlantı adresini tanımlıyoruz.

![image](https://github.com/user-attachments/assets/b4a687f6-efde-48fd-9f85-411af6e9357c)

📌 3. adımda context sınıfımızı oluşturuyoruz.

<code>public IDbConnection CreateConnection() => new SqlConnection(_ConnectionString) </code>
