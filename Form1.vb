Public Class Form1

    Public Sub New()
        InitializeComponent()
        ComboBox1.Items.Add("For God so loved the world, that He gave His only begotten Son that whosoever believes in Him shall not perish but have everlasting life. (John 3:16)")
        ComboBox1.Items.Add("In the beginning God created the heavens and the earth. (Genesis 1:1)")
        ComboBox1.Items.Add("There is none righteous, no, not one. (Romans 3:10)")
        ComboBox1.Items.Add("That if you confess with your mouth the Lord Jesus and believe in your heart God raised Him from the dead, you will be saved. (Romans 10:9)")
        ComboBox1.Items.Add("For the wages of sin is death, but the gift of God is life everlasting in Christ Jesus our Lord (Romans 3:23)")
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        RichTextBox1.Text = ComboBox1.SelectedItem.ToString
    End Sub
End Class
