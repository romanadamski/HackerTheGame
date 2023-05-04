public class MainMenuState : State
{
    private MapHud _mapHud;

    public MainMenuState(StateMachine stateMachine) : base(stateMachine) { }

    protected override void OnEnter()
    {
        if (_mapHud || UIManager.Instance.TryGetMenuByType(out _mapHud))
        {
            _mapHud.Show();
        }
    }

    protected override void OnExit()
    {
        if (_mapHud || UIManager.Instance.TryGetMenuByType(out _mapHud))
        {
            _mapHud.Hide();
        }
    }
}
