// Use this file for your unit tests.
// When you are ready to submit, REMOVE all using statements to Festival Manager (entities/controllers/etc)
// Test ONLY the Stage class. 
namespace FestivalManager.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    [TestFixture]
    public class StageTests
    {
        [Test]
        public void NullValueSongShouldThrowExp()
        {
            List<Song> Songs = new List<Song>();
            var song = Songs.FirstOrDefault(x => x.Name == "Gosho");

            Assert.AreEqual(null, song);
        }

        [Test]
        public void NullValuePerformerShouldThrowExp()
        {
            List<Performer> Performer = new List<Performer>();
            var performer = Performer.FirstOrDefault(x => x.FullName == "Gosho");
            Assert.AreEqual(null, performer);
        }

        [Test]
        public void PerformerAgeShouldThrowArgumentException()
        {
            Stage stage = new Stage();
            Performer performer = new Performer("Gosho", "Ivanov", 17);
            Assert.Throws<ArgumentException>(() => stage.AddPerformer(performer));
        }

        [Test]
        public void ShouldAddPerformerPropietly()
        {
            Stage stage = new Stage();
            Performer performer = new Performer("Gosho", "Ivanov", 19);
            stage.AddPerformer(performer);

            int expectedResult = 1;
            int actualResult = stage.Performers.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void DurationOfSongShouldThrowExp()
        {
            Stage stage = new Stage();
            TimeSpan timeSpan = TimeSpan.FromMinutes(0.5);
            Song song = new Song("Gosho", timeSpan);

            Assert.Throws<ArgumentException>(() => stage.AddSong(song));
        }

        [Test]
        public void SongShouldWork()
        {
            Stage stage = new Stage();
            TimeSpan timeSpan = TimeSpan.FromMinutes(2);
            Song song = new Song("Gosho", timeSpan);

            stage.AddSong(song);

            var expectedResult = "Gosho";
            var actualResult = song.Name;

            var expectedDuration = TimeSpan.FromMinutes(2);
            var actualDuration = song.Duration;

            Assert.AreEqual(expectedResult, actualResult);

            Assert.AreEqual(expectedDuration, actualDuration);
        }

        [Test]
        public void AddSongToPerformer()
        {
            TimeSpan timeSpan = TimeSpan.FromMinutes(2);
            Song song = new Song("Gosho", timeSpan);
            Performer performer = new Performer("Gosho", "Ivanov", 19);

            performer.SongList.Add(song);

            var actualREsult = performer.SongList.Count;
            int expectedResult = 1;

            Assert.AreEqual(expectedResult, actualREsult);
        }

        [Test]
        public void ShouldTestPlay()
        {
            Stage stage = new Stage();

            TimeSpan timeSpan = TimeSpan.FromMinutes(2);
            Song song = new Song("Gosho", timeSpan);
            Performer performer = new Performer("Gosho", "Ivanov", 19);

            performer.SongList.Add(song);

            stage.AddPerformer(performer);

            int ExpectedPerformersCount = 1;
            var ActualPerformersCount = stage.Performers.Count;

            Assert.AreEqual(ExpectedPerformersCount, ActualPerformersCount);

            int expectedSong = 1;
            int actualSongs = performer.SongList.Count;

            Assert.AreEqual(expectedSong, actualSongs);
        }

        [Test]
        public void ShouldTestGetPerformer()
        {
            List<Performer> performers = new List<Performer>();
            Performer performer = new Performer("Gosho", "Ivanov", 19);

            performers.Add(performer);

            var expectedPerformer = performer;
            var actualPerformer = performers.FirstOrDefault(x => x.FullName == "Gosho Ivanov");

            Assert.AreEqual(expectedPerformer, actualPerformer);
        }

        [Test]
        public void ShouldTestGetPerformerShouldThrowExp()
        {
            List<Performer> performers = new List<Performer>();
            Performer performer = new Performer("Gosho", "Ivanov", 19);

            performers.Add(performer);

            var expectedPerformer = performer;
            var actualPerformer = performers.FirstOrDefault(x => x.FullName == "Gosho Grigorov");

            Assert.AreEqual(null, actualPerformer);
        }

        [Test]
        public void ShouldTestGetSong()
        {
            List<Song> songs = new List<Song>();
            TimeSpan timeSpan = TimeSpan.FromMinutes(2);
            Song song = new Song("Gosho", timeSpan);
            songs.Add(song);
            var actualsong = songs.FirstOrDefault(x => x.Name == "Gosho");

            Assert.AreEqual(song, actualsong);
        }

        [Test]
        public void ShouldThrowExp()
        {

            List<Song> songs = new List<Song>();
            TimeSpan timeSpan = TimeSpan.FromMinutes(2);
            Song song = new Song("Gosho", timeSpan);
            songs.Add(song);

            var actualsong = songs.FirstOrDefault(x => x.Name == "Ivan");

            Assert.AreEqual(null, actualsong);
        }
    }
}