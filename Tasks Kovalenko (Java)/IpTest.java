import org.junit.Assert;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.junit.runners.Parameterized;

import java.util.Arrays;
import java.util.Collection;

@RunWith(Parameterized.class)
public class IpTest {
    private final Object[] INPUT_DATA;
    private final Object[] EXPECTED_DATA;

    public IpTest(Object[] inputData, Object[] expectedData) {
        this.INPUT_DATA = inputData;
        this.EXPECTED_DATA = expectedData;
    }

    @Parameterized.Parameters
    public static Collection cases() {
        return Arrays.asList(new Object[][][]{
                {{"127.0.0.1"}, {127, 0, 0, 1}},
                {{"0.0.0.0"}, {0, 0, 0, 0}},
                {{"255.255.255.0"}, {255, 255, 255, 0}},
                {{"10.0.0.10"}, {10, 0, 0, 10}},
                {{".0.0."}, null},
                {{"127001"}, null},
                {{"127.0.0"}, null},
                {{""}, null},
                {{"aa.44.bb.31"}, null},
                {{"aa.44.bb.31.55"}, null},
                {{"a3.2a.2a2.31.55"}, null},
        });
    }

    @Test
    public void fullTest() {
        Assert.assertEquals(EXPECTED_DATA, Ip.parseIP((String) INPUT_DATA[0]));
    }
}