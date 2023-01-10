import org.junit.Assert;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.junit.runners.Parameterized;
import java.util.Arrays;
import java.util.Collection;

@RunWith(Parameterized.class)
public class IpTest {
    private final Object[] inputData;
    private final Object[] expectedData;

    public IpTest(Object[] inputData, Object[] expectedData) {
        this.inputData = inputData;
        this.expectedData = expectedData;
    }

    @Parameterized.Parameters
    public static Collection cases(){
        return Arrays.asList(new Object[][][]{
                {{"127.0.0.1"}, {127, 0, 0, 1}},
                {{"0.0.0.0"}, {0, 0, 0, 0}},
                {{"255.255.255.0"}, {255, 255, 255, 0}},
                {{"10.0.0.10"}, {10, 0, 0, 10}},
                {{".0.0."}, null},
                {{"127001"}, null},
                {{"127.0.0"}, null},
                {{""}, null}
        });
    }

    @Test
    public void fullTest(){
        Assert.assertEquals(expectedData, Ip.parseIP((String) inputData[0]));
    }
}