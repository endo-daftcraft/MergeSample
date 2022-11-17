using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Daftcraft
{
    public class SamplePresenter : MonoBehaviour
    {
        [SerializeField]
        private Button _buttonShow;
        [SerializeField]
        private Button _buttonClose;
        [SerializeField]
        private Button _buttonHide;

        [SerializeField]
        private Animator _animator;

        // Start is called before the first frame update
        void Start()
        {
            _buttonShow.onClick.AddListener( OnClick_Show );
            _buttonClose.onClick.AddListener( OnClick_Close );
            _buttonHide.onClick.AddListener( OnClick_Hide );
        }

        private void OnClick_Show()
        {
            _animator?.SetFloat( "speed", 1f );
            _animator?.SetBool( "visible", true );
        }

        private void OnClick_Close()
        {
            _animator?.SetFloat( "speed", -1f );
            _animator?.SetBool( "visible", false );
            _animator?.Play( "Ofuda_anim_close", 0, 1f );
        }

        private void OnClick_Hide()
        {
            _animator?.SetFloat( "speed", 1f );
            _animator?.SetBool( "visible", false );
            _animator?.Play( "Ofuda_anim_hide" );
        }
    }
}
