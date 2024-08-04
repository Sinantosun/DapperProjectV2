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

📌 3. adımda context sınıfımızı oluşturuyoruz. <br> <br>
📌 private readonly IConfiguration _configuration; --> bu kısımda IConfiguration Interfacesinden bir örneği Constractr ile örnek aliyoruz bunun sebebi ise appsettings dosyasında geçtiğimiz bağlantı yolunu bu servis sayesinde okuyacağız <br> <br>
📌 private readonly string _ConnectionString; --> bağlantı adresimizi string olarak tutacak  <br> <br>
📌 _ConnectionString = _configuration.GetConnectionString("DefaultConnection"); --> Yukarda AppSettings.json dosyasınından bağlantı okumak için tamıladığımız interface içinde bulunan <b>"GetConnectionString()"<b/> methodu ile appsettings ConnectionString adı altında geçtiğimiz bağlantı adını buraya parametre olarak  ekliyoruz. <br> <br>
📌 public IDbConnection CreateConnection() => new SqlConnection(_ConnectionString); --> son işlem olarak IDbConnection yardımıyla oluşturduğumuz okuduğumz bağlantıyı sql connection sınıfına parametre olarak aktarıyoruz ve bu şekilde CreateConnection methodu cağırıldığında bağlantı oluşturulmuş olacak. <br> <br>
Not: SqlConnection using System.Data.SqlClient; nameSpacesi ile -- System.Data.SqlClient kütüphanesi ile gelmektedir, kullanılan veri tabanına göre bu kısım değişiklik gösterebilir.

<hr>

<h1>Dapper İle Veri Listeleme</h1>

![image](https://github.com/user-attachments/assets/c645c526-8a21-4517-b32a-8e37dd8a4813)

📌 listeleme işlemi için bütün tabloyu çekeceğiz bu sebeble select * from plates diyoruz ve bunu query adında bir değişkene atıyoruz.  <br> <br>
📌 context sınıfında oluşturduğumuz CreateConnection() methodunu connection değişkenine atıyoruz  <br>  <br>
📌 sonuçları result adında tutacağımız bir deşken oluşturuyor, oluşturduğumuz bağlantı sınıfına <b>"QueryAsync"<b/> ile sql sorgumuzu ve sql sorgusu neticesinde bize döncek verilerin dönüş türünü belirtiyoruz burada ResultCarDto türünde veriler gelecektir  <br> <br>
📌 Servislerimizi yazdıktan sonra ilgili controllere gidip servisi contstractr geçmeliyiz daha sonra methodu çağırıp dönen değerleri view içinde döndüğümüzde listeleme işlemi tamamlanacaktır. <br> <br>
<hr>

<h1> ☆ Proje Görselleri  ☆ </h1>

<h2> 📌 Dashboard Sayfası 📌</h2>
![image01](https://github.com/user-attachments/assets/ff4a3bbe-0f7e-4709-aa1a-addb57649e4d)

![image02](https://github.com/user-attachments/assets/6283a981-0c04-4e3d-8d3d-1cc641e06c6e)

📌 8 Widget 3 grafik 1 adet hızlı bakış tablosu dashboard alanında gösterilmektedir.

<hr>

<h2> 📌 Veri Listesi Sayfası 📌</h2>

![image03](https://github.com/user-attachments/assets/26eb0a8f-d915-4c25-804c-0c21f7fa3add)

📌 bu alanda x paged list ile veriler sayfalara bölünerek her sayfada 10 adet veri listeleniyor.

📌 Veri Listesi Sayfası Filtreleme işlemi

![image04](https://github.com/user-attachments/assets/b8a59185-a9ac-4e29-9cc8-7d5a34513b5b)

📌 Veri filtreme işlemi mercedes olarak girildiğinde geriye sadece filtreli sonuçlar dönmektedir.

![image05](https://github.com/user-attachments/assets/217a44ed-bee7-4f52-8f9b-8931d1ad28f8)

📌 aranan değer bulunamadığında ise sayfa içinde mesaj verilmektedir.
