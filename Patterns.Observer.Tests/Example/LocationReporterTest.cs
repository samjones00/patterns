using Patterns.Observer.Example;
using Xunit;

namespace Patterns.Observer.Tests.Example
{
    public class LocationReporterTest
    {
        [Fact]
        public void Test1()
        {
            LocationTrackerObservable locationTrackerObservable = new LocationTrackerObservable();
            LocationReporterObserver locationReporterObserver1 = new LocationReporterObserver("FixedGPS");
            locationReporterObserver1.Subscribe(locationTrackerObservable);
            LocationReporterObserver locationReporterObserver2 = new LocationReporterObserver("MobileGPS");
            locationReporterObserver2.Subscribe(locationTrackerObservable);

            locationTrackerObservable.TrackLocation(new Location(47.6456, -122.1312));
            locationReporterObserver1.Unsubscribe();
            locationTrackerObservable.TrackLocation(new Location(47.6677, -122.1199));
            locationTrackerObservable.TrackLocation(null);
            locationTrackerObservable.EndTransmission();
        }
    }
}
