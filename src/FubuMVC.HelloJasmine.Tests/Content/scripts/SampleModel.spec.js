describe('SampleModelTester', function () {
    it('should_have_defaults', function () {
        var model = new SampleModel();
        expect(model.get('name'))
            .toEqual('Hello, World!');
    });
});