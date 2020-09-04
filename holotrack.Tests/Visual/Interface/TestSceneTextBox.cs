using holotrack.Graphics.Interface;
using holotrack.Graphics.Sprites;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Testing;

namespace holotrack.Tests.Visual.Interface
{
    public class TestSceneTextBox : TestScene
    {
        public TestSceneTextBox()
        {
            Add(new FillFlowContainer
            {
                AutoSizeAxes = Axes.X,
                RelativeSizeAxes = Axes.Y,
                Direction = FillDirection.Vertical,
                Children = new Drawable[]
                {
                    new HoloTrackTextBox { Width = 300 },
                    new HoloTrackTextBox
                    {
                        Width = 300,
                        PlaceholderText = "placeholder",
                    },
                    new HoloTrackTextBox
                    {
                        Width = 300,
                        Text = "content",
                    },
                    new TestLabelledTextBox { Width = 300 },
                }
            });
        }

        private class TestLabelledTextBox : LabelledTextBox
        {
            protected override Drawable CreateLabel() => new HoloTrackSpriteText
            {
                Text = @"Label",
                Anchor = Anchor.Centre,
                Origin = Anchor.Centre,
                Margin = new MarginPadding { Horizontal = 5 },
            };
        }
    }
}