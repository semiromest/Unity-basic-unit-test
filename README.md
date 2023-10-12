# Unity-basic-unit-test

Neden Unit Test ?

1. Yazılım Kalitesini Artırır

Unity projelerinde unit testler, yazılımın kalitesini artırmak için kullanılır. Yazılım geliştirme sürecinde hatalar kaçınılmazdır, ancak bu hataların erken tespiti ve düzeltilmesi, projenin ilerlemesini kolaylaştırır. Unit testler, kodun farklı bileşenlerini test ederek, hataları erken aşamalarda tespit etmenizi sağlar. Bu sayede, hataların kodun daha karmaşık bir parçasına yayılmasını önleyebilir ve düzeltmeleri daha kolay yapabilirsiniz.

2. Güvenilirlik ve Dayanıklılık Sağlar

Video oyunları genellikle karmaşık ve büyük projelerdir. Oyunlar, kullanıcıların farklı platformlarda ve cihazlarda sorunsuzca çalışmasını gerektirir. Unit testler, oyunun farklı senaryolarda ve durumlarda nasıl davranacağını test etmenizi sağlar. Bu, oyunun geniş bir yelpazedeki kullanıcılar için güvenilir ve dayanıklı olmasını sağlar.

3. Kod Değişikliklerini Kolaylaştırır

Bir Unity projesi geliştikçe, kod tabanı genellikle büyür ve karmaşıklaşır. Bu, yeni özellikler eklerken veya mevcut kodu değiştirirken potansiyel hataları artırabilir. Unit testler, kod değişikliklerini daha güvenli hale getirir. Yeni bir kod parçası eklediğinizde veya mevcut bir kodu değiştirdiğinizde, unit testler sayesinde bu değişikliklerin mevcut işlevselliği bozup bozmadığını hızla tespit edebilirsiniz.

4. İşbirliğiyi Artırır

Bir Unity projesini birden fazla geliştirici veya ekip üzerinde çalıştırıyorsanız, unit testler işbirliğini artırır. Unit testler, farklı geliştiricilerin kendi kodlarını güncellerken mevcut işlevselliği bozup bozmadığını anlamalarına yardımcı olur. Bu, projenin daha koordineli bir şekilde geliştirilmesine katkıda bulunur.

5. Hata Ayıklamayı Kolaylaştırır

Bir oyun geliştirme projesinde hataları ayıklamak genellikle zaman alıcı bir işlemdir. Unit testler, hataları daha hızlı tespit etmenizi ve izole etmenizi sağlar. Testler başarısız olduğunda, hatanın hangi kod bölümünde olduğunu daha kolay belirleyebilirsiniz. Bu da hataların daha hızlı düzeltilmesini sağlar.


---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Unity Test Framework'ü Kurma:

Unity, Unity Test Framework'ü Unity Hub veya Unity Editör'ün paket yöneticisi ile eklemeyi kolaylaştırır. Aşağıdaki adımları takip edin:

a. Unity Editör'ü açın.

b. Menü çubuğunda "Window" (Pencere) seçeneğine gidin.

c. "Package Manager" (Paket Yöneticisi) seçeneğini seçin.

d. "Unity Registry" (Unity Kayıt Defteri) sekmesine gidin.

e. "Unity Test Framework" öğesini arayın ve yükleyin.

Test Runner'ı Başlatma:

Şimdi, Unity Test Runner'ı başlatmak için aşağıdaki adımları izleyin:

a. Menü çubuğunda "Window" (Pencere) seçeneğine gidin.

b. "General" altında "Test Runner" seçeneğini seçin.

c. Test Runner penceresi açılacak.

Test Assembly Eklemek:

Test Runner açıldığında, Unity projesindeki test senaryolarını eklemek için aşağıdaki adımları takip edin:

a. Test Runner penceresini açtığınızda karşınıza "Create EditMode Test Assembly Folder" butonu çıkacaktır.Buna tıklayarak gerekli dosyaları otomatik oluşturabilirsiniz.

b.Oluşturulan Tests klasörüne giriniz ve içinde ki assembly dosyasına tıklayınız(Bu dosya test yapmak için gerekli paketleri içerir ve testimizi organize eder).Tıklamadan sonra Test Runner penceresinde "Create Test Script in current folder" isminde bir 
buton belirecektir.Bu butona tıkladığınızda gerekli test scriptini otomatik şekilde oluşturacaktır.

c. Test Scriptinin içine testinizi yazıp kayıt ettikten sonra Test Runner penceresinde sol üstte "Run All" butonuna basarak testinizi başlatabilirsiniz.

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

İşte Test algoritmanızı yazmak için hazır verilen fonksiyonlar :

Assert.AreEqual(expected, actual): İki değerin eşit olup olmadığını kontrol eder.

Assert.AreNotEqual(notExpected, actual): İki değerin eşit olmadığını kontrol eder.

Assert.IsTrue(condition): Belirli bir koşulun doğru olduğunu kontrol eder.

Assert.IsFalse(condition): Belirli bir koşulun yanlış olduğunu kontrol eder.

Assert.IsNull(actual): Bir değerin null (boş) olduğunu kontrol eder.

Assert.IsNotNull(actual): Bir değerin null (boş) olmadığını kontrol eder.

Assert.AreSame(expected, actual): İki nesnenin aynı nesne olduğunu kontrol eder.

Assert.AreNotSame(notExpected, actual): İki nesnenin farklı nesneler olduğunu kontrol eder.

Assert.That(actual, expression): Belirli bir ifadeyi kullanarak bir koşulu kontrol eder.

Assert.Greater(actual, expected): Bir değerin başka bir değerden büyük olduğunu kontrol eder.

Assert.Less(actual, expected): Bir değerin başka bir değerden küçük olduğunu kontrol eder.

Assert.Throws(exceptionType, code): Belirli bir türde istisna fırlatılıp fırlatılmadığını kontrol eder.

Assert.DoesNotThrow(code): Herhangi bir istisna fırlatılmadığını kontrol eder.

Örnek olarak hazır scripti kopyalayıp projenizde test edebilirsiniz.
