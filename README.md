#ENGLISH/TÜRKÇE

## Project Description

This project is an enterprise-level Web API solution developed using the C# programming language and .NET platform. The project is built on the ASP.NET framework and utilizes Entity Framework for database operations. Additionally, Autofac library is used to implement the Inversion of Control (IoC) principle, and necessary structures for JWT token-based authentication processes are integrated.

## Technologies and Structures Used

- **C# and .NET**: The project is built on the C# programming language and .NET technology stack, providing a powerful and scalable solution.
  
- **ASP.NET Web API**: The project is developed using ASP.NET framework, enabling the design and implementation of RESTful APIs.
  
- **Entity Framework**: Entity Framework is used for database operations, making database management easier and reducing complexity associated with database interactions.
  
- **IoC (Inversion of Control) and Autofac**: Autofac is preferred for implementing the IoC principle in the project. This reduces dependencies and increases code testability. Dependency Injection mechanism is also utilized.

- **JWT Token-based Authentication**: JWT (JSON Web Token) based authentication structure is integrated into the project for user authentication processes. This ensures secure authentication and authorization mechanisms.

## Installation and Getting Started

To run the project on your local machine, follow these steps:

1. Clone or download the project to your computer.
2. Open the project in Visual Studio or your preferred IDE.
3. Restore dependencies (using NuGet Package Manager or by running `dotnet restore` command).
4. Configure database connection settings in the `appsettings.json` file.
5. Build and run the project.
6. Test the functionality by accessing the API.

## Contribution

If you would like to contribute to this project, please create a pull request. You can add new features or improve existing code to enhance the project.

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

# Projemizin Tanımı

Bu proje, C# programlama dili ve .NET platformu kullanılarak geliştirilmiş, kurumsal düzeyde bir Web API çözümüdür. Proje, ASP.NET framework'ü üzerinde inşa edilmiş olup, Entity Framework ile veritabanı işlemleri gerçekleştirilmiştir. Ayrıca, Inversion of Control (IoC) prensibini uygulamak için Autofac kütüphanesinden yararlanılmış ve JWT token tabanlı kimlik doğrulama işlemleri için gerekli yapılar entegre edilmiştir.

## Kullanılan Teknolojiler ve Yapılar

- **C# ve .NET**: Proje, C# programlama dili ve .NET teknoloji yığını üzerine kurulmuştur, bu da güçlü ve ölçeklenebilir bir çözüm sunmamıza olanak tanımıştır.
  
- **ASP.NET Web API**: Projemiz, ASP.NET framework'ü kullanılarak geliştirilmiş, RESTful API'lerin tasarımı ve uygulanmasına olanak sağlayan bir yapı üzerine inşa edilmiştir.
  
- **Entity Framework**: Veritabanı işlemleri için Entity Framework kullanılmıştır. Bu sayede, veritabanı işlemleri kolayca yönetilebilir hale gelmiş ve veri tabanı ile ilişkili karmaşıklık azaltılmıştır.
  
- **IoC (Inversion of Control) ve Autofac**: Projede IoC prensibini uygulamak için Autofac tercih edilmiştir. Bu sayede bağımlılıklar azaltılmış ve kodun test edilebilirliği arttırılmıştır. Dependency Injection mekanizması da bu sayede kullanılmıştır.

- **JWT Token Tabanlı Kimlik Doğrulama**: Projede kullanıcı kimlik doğrulama işlemleri için JWT (JSON Web Token) tabanlı bir yapı entegre edilmiştir. Bu sayede, güvenli bir kimlik doğrulama ve yetkilendirme mekanizması sağlanmıştır.

## Proje Yapısı ve Mimari

Proje, katmanlı bir mimariye sahiptir, bu da kodun düzenli ve bakımı kolay olmasını sağlamıştır. Her bir katman, tek bir sorumluluğa odaklanarak, kodun daha okunabilir ve yönetilebilir olmasını sağlar.

- **Sunum Katmanı (Presentation Layer)**: Bu katman, API kontrolcülerini ve API'nin dış dünyaya açık olan kısmını içerir. Kullanıcı isteklerini alır ve iş mantığı katmanına iletir.

- **İş Mantığı Katmanı (Business Logic Layer)**: İş mantığı kurallarının uygulandığı katmandır. Veri işleme, doğrulama ve yetkilendirme gibi işlemler burada gerçekleştirilir.

- **Veri Erişim Katmanı (Data Access Layer)**: Veritabanı işlemlerinin gerçekleştirildiği katmandır. Entity Framework kullanılarak veri tabanı işlemleri bu katmanda gerçekleştirilir.

- **Servis Katmanı (Service Layer)**: Harici servislerle (örneğin, e-posta gönderme servisi gibi) iletişim kurulan katmandır. Bu katman, dış sistemlerle etkileşimi yönetir ve servis çağrılarını işler.

## Kurulum ve Başlangıç

Projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları izleyebilirsiniz:

1. Projeyi bilgisayarınıza klonlayın veya indirin.
2. Visual Studio veya tercih ettiğiniz bir IDE ile projeyi açın.
3. Bağımlılıkları restore edin (NuGet Paket Yöneticisi kullanarak veya `dotnet restore` komutunu çalıştırarak).
4. Veritabanı bağlantı ayarlarınızı `appsettings.json` dosyasında yapılandırın.
5. Projeyi derleyin ve çalıştırın.
6. API'ye erişim sağlayarak fonksiyonelliği test edin.

## Katkıda Bulunma

Eğer bu projeye katkıda bulunmak istiyorsanız, lütfen bir çekme isteği (pull request) oluşturun. Projeyi geliştirmek için yeni özellikler ekleyebilir veya mevcut kodu iyileştirebilirsiniz.
